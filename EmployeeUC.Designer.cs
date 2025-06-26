using System.ComponentModel;

namespace WinFormsApp2;

partial class EmployeeUC {
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

    #region Component Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        panel1 = new System.Windows.Forms.Panel();
        createEmployeeBtn = new System.Windows.Forms.Button();
        panelMain = new System.Windows.Forms.Panel();
        newEmployeeBtn = new System.Windows.Forms.Button();
        panelTop = new System.Windows.Forms.Panel();
        panel2 = new System.Windows.Forms.Panel();
        panel1.SuspendLayout();
        panelTop.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
        panel1.Controls.Add(createEmployeeBtn);
        panel1.Cursor = System.Windows.Forms.Cursors.Default;
        panel1.Dock = System.Windows.Forms.DockStyle.Top;
        panel1.Location = new System.Drawing.Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(988, 154);
        panel1.TabIndex = 0;
        // 
        // createEmployeeBtn
        // 
        createEmployeeBtn.Cursor = System.Windows.Forms.Cursors.Default;
        createEmployeeBtn.Location = new System.Drawing.Point(52, 62);
        createEmployeeBtn.Name = "createEmployeeBtn";
        createEmployeeBtn.Size = new System.Drawing.Size(168, 37);
        createEmployeeBtn.TabIndex = 0;
        createEmployeeBtn.Text = "New Employee";
        createEmployeeBtn.UseVisualStyleBackColor = true;
        createEmployeeBtn.Click += createEmployeeBtn_Click;
        // 
        // panelMain
        // 
        panelMain.BackColor = System.Drawing.SystemColors.ActiveBorder;
        panelMain.Cursor = System.Windows.Forms.Cursors.Default;
        panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
        panelMain.Location = new System.Drawing.Point(0, 154);
        panelMain.Name = "panelMain";
        panelMain.Size = new System.Drawing.Size(988, 614);
        panelMain.TabIndex = 1;
        // 
        // newEmployeeBtn
        // 
        newEmployeeBtn.Location = new System.Drawing.Point(64, 32);
        newEmployeeBtn.Name = "newEmployeeBtn";
        newEmployeeBtn.Size = new System.Drawing.Size(168, 37);
        newEmployeeBtn.TabIndex = 0;
        newEmployeeBtn.Text = "New Employee";
        newEmployeeBtn.UseVisualStyleBackColor = true;
        // 
        // panelTop
        // 
        panelTop.Controls.Add(newEmployeeBtn);
        panelTop.Dock = System.Windows.Forms.DockStyle.Top;
        panelTop.Location = new System.Drawing.Point(0, 0);
        panelTop.Name = "panelTop";
        panelTop.Size = new System.Drawing.Size(988, 103);
        panelTop.TabIndex = 4;
        panelTop.Visible = false;
        // 
        // panel2
        // 
        panel2.BackColor = System.Drawing.SystemColors.Info;
        panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
        panel2.Location = new System.Drawing.Point(0, 768);
        panel2.Name = "panel2";
        panel2.Size = new System.Drawing.Size(988, 161);
        panel2.TabIndex = 2;
        // 
        // EmployeeUC
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.Control;
        Controls.Add(panelMain);
        Controls.Add(panel2);
        Controls.Add(panel1);
        Cursor = System.Windows.Forms.Cursors.Default;
        Size = new System.Drawing.Size(988, 929);
        panel1.ResumeLayout(false);
        panelTop.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Panel panel2;

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panelMain;
    private System.Windows.Forms.Button createEmployeeBtn;
    private System.Windows.Forms.Button newEmployeeBtn;
    private System.Windows.Forms.Panel panelTop;

    #endregion
}