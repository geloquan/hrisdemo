using System.ComponentModel;

namespace WinFormsApp2.WinForm;

partial class EmployeeCreateForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        panelMain = new System.Windows.Forms.Panel();
        SuspendLayout();
        // 
        // panelMain
        // 
        panelMain.AutoSize = true;
        panelMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
        panelMain.Location = new System.Drawing.Point(0, 0);
        panelMain.Name = "panelMain";
        panelMain.Size = new System.Drawing.Size(800, 450);
        panelMain.TabIndex = 0;
        // 
        // EmployeeCreateForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        AutoSize = true;
        AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(panelMain);
        Text = "Create: Employee";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Panel panelMain;

    #endregion
}