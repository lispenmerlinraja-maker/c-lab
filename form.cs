using System;
using System.Windows.Forms;

class Form1 : Form
{
    Label lblName;
    TextBox txtName;
    Button btnDisplay;

    public Form1()
    {
        // Label
        lblName = new Label();
        lblName.Text = "Enter Name:";
        lblName.Location = new System.Drawing.Point(30, 30);

        // TextBox
        txtName = new TextBox();
        txtName.Location = new System.Drawing.Point(120, 30);

        // Button
        btnDisplay = new Button();
        btnDisplay.Text = "Display";
        btnDisplay.Location = new System.Drawing.Point(120, 70);

        // Button click event
        btnDisplay.Click += BtnDisplay_Click;

        // Add controls to Form
        Controls.Add(lblName);
        Controls.Add(txtName);
        Controls.Add(btnDisplay);

        // Form properties
        Text = "Student Form";
        Width = 400;
        Height = 200;
    }

    private void BtnDisplay_Click(object? sender, EventArgs e)
    {
        MessageBox.Show("Student Name: " + txtName.Text);
    }

    static void Main()
    {
        Application.Run(new Form1());
    }
}