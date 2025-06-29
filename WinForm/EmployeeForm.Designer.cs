using System.ComponentModel;

namespace WinFormsApp2.WinForm;

partial class FormTitleLbl {
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
    panelMain = new Panel();
    SuspendLayout();
    // 
    // panelMain
    // 
    panelMain.AutoSize = true;
    panelMain.AutoSizeMode = AutoSizeMode.GrowAndShrink;
    panelMain.Dock = DockStyle.Fill;
    panelMain.Location = new Point(0, 0);
    panelMain.Margin = new Padding(2);
    panelMain.Name = "panelMain";
    panelMain.Size = new Size(560, 270);
    panelMain.TabIndex = 0;
    // 
    // FormTitleLbl
    // 
    AutoScaleDimensions = new SizeF(7F, 15F);
    AutoScaleMode = AutoScaleMode.Font;
    AutoSize = true;
    AutoSizeMode = AutoSizeMode.GrowAndShrink;
    ClientSize = new Size(560, 270);
    Controls.Add(panelMain);
    Margin = new Padding(2);
    Name = "FormTitleLbl";
    Text = "Form Title";
    ResumeLayout(false);
    PerformLayout();
  }

  private System.Windows.Forms.Panel panelMain;

    #endregion
}