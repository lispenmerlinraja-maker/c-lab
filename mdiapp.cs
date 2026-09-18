using System;
using System.Drawing;
using System.Windows.Forms;

class MainForm : Form
{
    MenuStrip menu;
    ToolStripMenuItem fileMenu;
    ToolStripMenuItem dialogMenu;

    public MainForm()
    {
        Text = "MDI Application";
        Width = 800;
        Height = 500;

        // MDI Parent
        IsMdiContainer = true;

        // Menu
        menu = new MenuStrip();

        fileMenu = new ToolStripMenuItem("File");
        dialogMenu = new ToolStripMenuItem("Custom Dialog");

        dialogMenu.Click += DialogMenu_Click;

        fileMenu.DropDownItems.Add(dialogMenu);
        menu.Items.Add(fileMenu);

        Controls.Add(menu);
        MainMenuStrip = menu;
    }

    private void DialogMenu_Click(object? sender, EventArgs e)
    {
        CustomDialog dialog = new CustomDialog();
        dialog.ShowDialog();
    }
}


// Custom Dialog Box
class CustomDialog : Form
{
    Label lblName;
    TextBox txtName;
    Button btnOK;
    Button btnCancel;

    public CustomDialog()
    {
        Text = "Custom Dialog Box";
        Width = 350;
        Height = 200;

        // Label
        lblName = new Label();
        lblName.Text = "Enter Name:";
        lblName.Location = new Point(30, 30);

        // TextBox
        txtName = new TextBox();
        txtName.Location = new Point(120, 30);

        // OK Button
        btnOK = new Button();
        btnOK.Text = "OK";
        btnOK.Location = new Point(80, 80);

        // Cancel Button
        btnCancel = new Button();
        btnCancel.Text = "Cancel";
        btnCancel.Location = new Point(170, 80);

        // Events
        btnOK.Click += BtnOK_Click;
        btnCancel.Click += BtnCancel_Click;

        // Add controls
        Controls.Add(lblName);
        Controls.Add(txtName);
        Controls.Add(btnOK);
        Controls.Add(btnCancel);
    }

    private void BtnOK_Click(object? sender, EventArgs e)
    {
        MessageBox.Show("Hello " + txtName.Text);
    }

    private void BtnCancel_Click(object? sender, EventArgs e)
    {
        Close();
    }
}


// Main Method
class Program
{
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new MainForm());
    }
}