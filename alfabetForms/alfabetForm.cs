using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace alfabetForms {
  public partial class alfabetForm : Form {
    public alfabetForm() {
      InitializeComponent();
    }

    private string controlsInfoStr;
    private string formTitle;
    public dbEntities db; 
     Controls  ctrls;

    private void alfabetForm_Load(object sender, EventArgs e)
    {
      formTitle = Text;

      checkForm( );
    }

    //Check whether form is in ReadOnly mode or available for Editing
    private void checkForm( )
    {
       db= new dbEntities();
      ctrls = (from r in db.Controls
        where r.FormID == (string) Tag
        select r).SingleOrDefault();

      bool BeingModified = false;
      if (ctrls != null) BeingModified=(bool) ctrls.BeingModified;

      if (BeingModified && !timer1.Enabled)
      {
        Text = formTitle+ " - ReadOnly";
        loadControls();
        menuStrip1.BackColor = Color.LightCoral;
        menuStrip1.Enabled = false;
        timer1.Enabled = true;
      }
      else if(!BeingModified) //enable form
      {

        resetControls();
        formTitle =  Text;
        menuStrip1.Enabled = true;
        if (ctrls != null) loadControls();
        Invalidate();
       timer1.Enabled = false;
      }
    }

    //Refresh form and load its controls from the database
    private void loadControls()
    {
      foreach (Control ctrl in Controls) {
        if (ctrl.GetType() == typeof(TextBox) || ctrl.GetType() == typeof(Button))
          Controls.Remove(ctrl);
      }
      controlsInfoStr = ctrls.Controls1;
      string[] controlsInfo = controlsInfoStr.Split(new[] {"*"}, StringSplitOptions.RemoveEmptyEntries);

      foreach (string controlInfo in controlsInfo)
      {
        string[] info = controlInfo.Split(new[] {":"}, StringSplitOptions.RemoveEmptyEntries);
        String ctrlName = info[0];
        var val = info[1].Split(',').Select(Int32.Parse).ToList();
        addCtrl(ctrlName, val[0], val[1], val[2], val[3]);
      }
    }

    private void editToolStripMenuItem_Click(object sender, EventArgs e) {
      menuStrip1.BackColor = Color.LightGreen;

      if (ctrls != null) {
        ctrls.BeingModified = true;
        db.SaveChanges();
      }
    

      this.Text += " - Editing";
      editToolStripMenuItem.Enabled = false;
      addNewToolStripMenuItem.Enabled = true;

      if (!string.IsNullOrWhiteSpace(controlsInfoStr)) {
        ControlMoverOrResizer.SetSizeAndPositionOfControlsFromString(this, controlsInfoStr);
      }

      foreach (Control ctrl in Controls) {
        if (ctrl.GetType() == typeof(TextBox) || ctrl.GetType() == typeof(Button))
          ControlMoverOrResizer.Init(ctrl);
      }
      controlsInfoStr = ControlMoverOrResizer.GetSizeAndPositionOfControlsToString(this);
    }

    private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
      controlsInfoStr = ControlMoverOrResizer.GetSizeAndPositionOfControlsToString(this);

      ctrls.Controls1 = controlsInfoStr;
      ctrls.BeingModified = false;
      db.SaveChanges();

      resetControls();
    }

    private void resetControls() {
      editToolStripMenuItem.Enabled = true;
      Text = formTitle;
      addNewToolStripMenuItem.Enabled = false;
      Invalidate();
      menuStrip1.BackColor = Color.Transparent;

        ControlMoverOrResizer.Stop ( );
    }

  private void resetToolStripMenuItem_Click(object sender, EventArgs e) {
      if (!string.IsNullOrWhiteSpace(controlsInfoStr)) {
        ControlMoverOrResizer.SetSizeAndPositionOfControlsFromString(this, controlsInfoStr);
        resetControls();
      }
    }

    private void textBoxToolStripMenuItem_Click(object sender, EventArgs e) {
      String newCtrl = getNextCtrlName("textbox");
      addCtrl(newCtrl);
      ControlMoverOrResizer.Init(Controls[newCtrl]);
    }

    private void buttonToolStripMenuItem_Click(object sender, EventArgs e) {
      String newCtrl = getNextCtrlName("button");
      addCtrl(newCtrl);
      ControlMoverOrResizer.Init(Controls[newCtrl]);
    }

    // adding controls t othe form. TextBox and Button ctrls are avaialble
    private void addCtrl(String ctrlName, int posX= 100, int posY=100, int width=175,int height=30 ) {
      dynamic ctrl = null;
      if (ctrlName.ToLower().StartsWith("textbox"))
      {
      ctrl = new TextBox();
      ctrl.Multiline = true;
      }
      
      if (ctrlName.ToLower().StartsWith("button")) ctrl = new Button();
     
      ctrl.Name = ctrlName;
      ctrl.Location = new Point(posX, posY);
      ctrl.Size = new  Size(width, height);
      ctrl.Text = ctrl.Name;
      
      Controls.Add(ctrl);
      controlsInfoStr = ControlMoverOrResizer.GetSizeAndPositionOfControlsToString(this);
    }

    //generate control name
    private string getNextCtrlName(String seed, int n=0)
    {
      String newName = seed + n;
      foreach (Control ctrl in Controls) {
        if (ctrl.Name.ToLower() == newName.ToLower())
        {
          return getNextCtrlName(seed, n + 1);
          break;
        }
      }

        return newName;
    }

    //Check whether the form is enabled for editing
    private void timer1_Tick(object sender, EventArgs e) {
      checkForm( );
    }
  }
}
