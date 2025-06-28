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
    DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
    employeeDgv.BackgroundColor = SystemColors.ButtonHighlight;
    employeeDgv.BorderStyle = BorderStyle.None;
    employeeDgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
    employeeDgv.ColumnHeadersHeight = 34;
    dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
    dataGridViewCellStyle1.BackColor = SystemColors.Window;
    dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
    dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
    dataGridViewCellStyle1.Padding = new Padding(5, 2, 5, 2);
    dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlLight;
    dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
    dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
    employeeDgv.DefaultCellStyle = dataGridViewCellStyle1;
    employeeDgv.Dock = DockStyle.Fill;
    employeeDgv.Location = new Point(0, 0);
    employeeDgv.Margin = new Padding(2);
    employeeDgv.MultiSelect = false;
    employeeDgv.Name = "employeeDgv";
    employeeDgv.ReadOnly = true;
    employeeDgv.RowHeadersWidth = 62;
    employeeDgv.RowTemplate.Height = 33;
    employeeDgv.Size = new Size(892, 624);
    employeeDgv.TabIndex = 0;
    employeeDgv.CellContentClick += employeeDgv_CellContentClick_1;
    // 
    // EmployeeTable
    // 
    AutoScaleDimensions = new SizeF(7F, 15F);
    AutoScaleMode = AutoScaleMode.Font;
    BackColor = SystemColors.Control;
    Controls.Add(employeeDgv);
    Location = new Point(22, 22);
    Margin = new Padding(2);
    Name = "EmployeeTable";
    Size = new Size(892, 624);
    ((ISupportInitialize)employeeDgv).EndInit();
    ResumeLayout(false);
  }

  private System.Windows.Forms.DataGridView employeeDgv;

    #endregion
}