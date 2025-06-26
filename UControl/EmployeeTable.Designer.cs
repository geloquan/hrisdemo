using System.ComponentModel;

namespace WinFormsApp2.UControl;

partial class EmployeeTable {
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
    employeeDgv = new DataGridView();
    ((ISupportInitialize)employeeDgv).BeginInit();
    SuspendLayout();
    // 
    // employeeDgv
    // 
    employeeDgv.AllowUserToAddRows = false;
    employeeDgv.AllowUserToDeleteRows = false;
    employeeDgv.AllowUserToResizeColumns = false;
    employeeDgv.AllowUserToResizeRows = false;
    employeeDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
    employeeDgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
    employeeDgv.ColumnHeadersHeight = 34;
    employeeDgv.Dock = DockStyle.Fill;
    employeeDgv.Location = new Point(0, 0);
    employeeDgv.Name = "employeeDgv";
    employeeDgv.ReadOnly = true;
    employeeDgv.RowHeadersWidth = 62;
    employeeDgv.RowTemplate.Height = 33;
    employeeDgv.Size = new Size(1275, 1040);
    employeeDgv.TabIndex = 0;
    // 
    // EmployeeTable
    // 
    AutoScaleDimensions = new SizeF(10F, 25F);
    AutoScaleMode = AutoScaleMode.Font;
    BackColor = SystemColors.Control;
    Controls.Add(employeeDgv);
    Location = new Point(22, 22);
    Name = "EmployeeTable";
    Size = new Size(1275, 1040);
    ((ISupportInitialize)employeeDgv).EndInit();
    ResumeLayout(false);
  }

  private System.Windows.Forms.DataGridView employeeDgv;

    #endregion
}