using System.ComponentModel;

namespace WinFormsApp2;

partial class MainForm {
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
        panelTab = new System.Windows.Forms.Panel();
        panel4 = new System.Windows.Forms.Panel();
        label1 = new System.Windows.Forms.Label();
        panel3 = new System.Windows.Forms.Panel();
        ticketBtn = new System.Windows.Forms.Button();
        departmentBtn = new System.Windows.Forms.Button();
        employeeBtn = new System.Windows.Forms.Button();
        panelMain = new System.Windows.Forms.Panel();
        titleTabLbl = new System.Windows.Forms.Label();
        panel1 = new System.Windows.Forms.Panel();
        panelTab.SuspendLayout();
        panel4.SuspendLayout();
        panel3.SuspendLayout();
        SuspendLayout();
        // 
        // panelTab
        // 
        panelTab.Controls.Add(panel4);
        panelTab.Controls.Add(panel3);
        panelTab.Dock = System.Windows.Forms.DockStyle.Left;
        panelTab.Location = new System.Drawing.Point(0, 0);
        panelTab.Name = "panelTab";
        panelTab.Size = new System.Drawing.Size(200, 774);
        panelTab.TabIndex = 1;
        // 
        // panel4
        // 
        panel4.BackColor = System.Drawing.SystemColors.ActiveBorder;
        panel4.Controls.Add(label1);
        panel4.Dock = System.Windows.Forms.DockStyle.Top;
        panel4.Location = new System.Drawing.Point(0, 0);
        panel4.Name = "panel4";
        panel4.Size = new System.Drawing.Size(200, 100);
        panel4.TabIndex = 4;
        // 
        // label1
        // 
        label1.Dock = System.Windows.Forms.DockStyle.Fill;
        label1.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        label1.Location = new System.Drawing.Point(0, 0);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(200, 100);
        label1.TabIndex = 0;
        label1.Text = "HRIS DEMO";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // panel3
        // 
        panel3.Controls.Add(ticketBtn);
        panel3.Controls.Add(departmentBtn);
        panel3.Controls.Add(employeeBtn);
        panel3.Dock = System.Windows.Forms.DockStyle.Fill;
        panel3.Location = new System.Drawing.Point(0, 0);
        panel3.Name = "panel3";
        panel3.Size = new System.Drawing.Size(200, 774);
        panel3.TabIndex = 3;
        // 
        // ticketBtn
        // 
        ticketBtn.Location = new System.Drawing.Point(0, 202);
        ticketBtn.Name = "ticketBtn";
        ticketBtn.Size = new System.Drawing.Size(200, 42);
        ticketBtn.TabIndex = 5;
        ticketBtn.Text = "Ticket";
        ticketBtn.UseVisualStyleBackColor = true;
        ticketBtn.Click += ticketBtn_Click;
        // 
        // departmentBtn
        // 
        departmentBtn.Location = new System.Drawing.Point(0, 154);
        departmentBtn.Name = "departmentBtn";
        departmentBtn.Size = new System.Drawing.Size(200, 42);
        departmentBtn.TabIndex = 4;
        departmentBtn.Text = "Department";
        departmentBtn.UseVisualStyleBackColor = true;
        departmentBtn.Click += departmentBtn_Click;
        // 
        // employeeBtn
        // 
        employeeBtn.Location = new System.Drawing.Point(0, 106);
        employeeBtn.Name = "employeeBtn";
        employeeBtn.Size = new System.Drawing.Size(200, 42);
        employeeBtn.TabIndex = 3;
        employeeBtn.Text = "Employee";
        employeeBtn.UseVisualStyleBackColor = true;
        employeeBtn.Click += employeeBtn_Click;
        // 
        // panelMain
        // 
        panelMain.AutoSize = true;
        panelMain.BackColor = System.Drawing.SystemColors.GrayText;
        panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
        panelMain.Location = new System.Drawing.Point(200, 100);
        panelMain.Name = "panelMain";
        panelMain.Size = new System.Drawing.Size(1086, 494);
        panelMain.TabIndex = 2;
        // 
        // titleTabLbl
        // 
        titleTabLbl.Cursor = System.Windows.Forms.Cursors.Arrow;
        titleTabLbl.Dock = System.Windows.Forms.DockStyle.Top;
        titleTabLbl.Font = new System.Drawing.Font("Baskerville Old Face", 18F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)), System.Drawing.GraphicsUnit.Point);
        titleTabLbl.Location = new System.Drawing.Point(200, 0);
        titleTabLbl.Name = "titleTabLbl";
        titleTabLbl.Size = new System.Drawing.Size(1086, 100);
        titleTabLbl.TabIndex = 0;
        titleTabLbl.Text = "TITLE TAB";
        titleTabLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // panel1
        // 
        panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
        panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
        panel1.Location = new System.Drawing.Point(200, 594);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(1086, 180);
        panel1.TabIndex = 3;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1286, 774);
        Controls.Add(panelMain);
        Controls.Add(panel1);
        Controls.Add(titleTabLbl);
        Controls.Add(panelTab);
        Text = "MainForm";
        panelTab.ResumeLayout(false);
        panel4.ResumeLayout(false);
        panel3.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Panel panel1;

    private System.Windows.Forms.Label titleTabLbl;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Panel panel4;

    private System.Windows.Forms.Panel panel3;

    private System.Windows.Forms.Panel panelMain;

    private System.Windows.Forms.Panel panelTab;
    private System.Windows.Forms.Button employeeBtn;
    private System.Windows.Forms.Button departmentBtn;
    private System.Windows.Forms.Button ticketBtn;

    #endregion
}