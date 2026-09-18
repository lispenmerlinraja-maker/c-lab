using System;
using System.Drawing;
using System.Windows.Forms;

class Form1 : Form
{
    Label lblName;
    TextBox txtName;
    Button btnDisplay;

    public Form1()
    {
        // Form properties
        Text = "Student Form";
        Width = 400;
        Height = 250;

        // Label
        lblName = new Label();
        lblName.Text = "Enter Name:";
        lblName.Location = new Point(30, 40);

        // TextBox
        txtName = new TextBox();
        txtName.Location = new Point(130, 40);

        // Button
        btnDisplay = new Button();
        btnDisplay.Text = "Display";
        btnDisplay.Location = new Point(130, 80);

        // Button event
        btnDisplay.Click += BtnDisplay_Click;

        // Add controls
        Controls.Add(lblName);
        Controls.Add(txtName);
        Controls.Add(btnDisplay);
    }

    private void BtnDisplay_Click(object? sender, EventArgs e)
    {
        MessageBox.Show("Hello " + txtName.Text);
    }

    static void Main()
    {
        Application.Run(new Form1());
    }
}
