partial class Form1
{
    private System.ComponentModel.IContainer? components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblTitle = new Label();
        cmbFrom = new ComboBox();
        cmbTo = new ComboBox();
        btnSwap = new Button();
        txtWord = new TextBox();
        btnTranslate = new Button();
        txtResult = new TextBox();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        lblTitle.ForeColor = Color.FromArgb(242, 177, 52);
        lblTitle.Location = new Point(24, 16);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(286, 37);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "3 хэлний толь бичиг";
        // 
        // cmbFrom
        // 
        cmbFrom.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbFrom.Font = new Font("Segoe UI", 12F);
        cmbFrom.Location = new Point(24, 70);
        cmbFrom.Name = "cmbFrom";
        cmbFrom.Size = new Size(165, 36);
        cmbFrom.TabIndex = 0;
        // 
        // cmbTo
        // 
        cmbTo.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbTo.Font = new Font("Segoe UI", 12F);
        cmbTo.Location = new Point(271, 70);
        cmbTo.Name = "cmbTo";
        cmbTo.Size = new Size(165, 36);
        cmbTo.TabIndex = 2;
        cmbTo.SelectedIndexChanged += cmbTo_SelectedIndexChanged;
        // 
        // btnSwap
        // 
        btnSwap.BackColor = Color.FromArgb(77, 111, 108);
        btnSwap.FlatAppearance.BorderSize = 0;
        btnSwap.FlatStyle = FlatStyle.Flat;
        btnSwap.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btnSwap.ForeColor = Color.FromArgb(241, 245, 238);
        btnSwap.Location = new Point(199, 67);
        btnSwap.Name = "btnSwap";
        btnSwap.Size = new Size(62, 34);
        btnSwap.TabIndex = 1;
        btnSwap.Text = "⇄";
        btnSwap.UseVisualStyleBackColor = false;
        // 
        // txtWord
        // 
        txtWord.Font = new Font("Segoe UI", 14F);
        txtWord.Location = new Point(24, 118);
        txtWord.Name = "txtWord";
        txtWord.PlaceholderText = "Үгээ энд бичнэ үү...";
        txtWord.Size = new Size(412, 39);
        txtWord.TabIndex = 3;
        // 
        // btnTranslate
        // 
        btnTranslate.BackColor = Color.FromArgb(242, 177, 52);
        btnTranslate.Cursor = Cursors.Hand;
        btnTranslate.FlatAppearance.BorderSize = 0;
        btnTranslate.FlatStyle = FlatStyle.Flat;
        btnTranslate.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
        btnTranslate.ForeColor = Color.FromArgb(42, 29, 0);
        btnTranslate.Location = new Point(24, 166);
        btnTranslate.Name = "btnTranslate";
        btnTranslate.Size = new Size(412, 46);
        btnTranslate.TabIndex = 4;
        btnTranslate.Text = "Орчуулах";
        btnTranslate.UseVisualStyleBackColor = false;
        // 
        // txtResult
        // 
        txtResult.BackColor = Color.FromArgb(232, 239, 228);
        txtResult.BorderStyle = BorderStyle.None;
        txtResult.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        txtResult.ForeColor = Color.FromArgb(29, 43, 42);
        txtResult.Location = new Point(24, 232);
        txtResult.Multiline = true;
        txtResult.Name = "txtResult";
        txtResult.ReadOnly = true;
        txtResult.Size = new Size(412, 140);
        txtResult.TabIndex = 5;
        txtResult.TabStop = false;
        // 
        // Form1
        // 
        AutoScaleMode = AutoScaleMode.None;
        BackColor = Color.FromArgb(38, 57, 58);
        ClientSize = new Size(460, 396);
        Controls.Add(lblTitle);
        Controls.Add(cmbFrom);
        Controls.Add(btnSwap);
        Controls.Add(cmbTo);
        Controls.Add(txtWord);
        Controls.Add(btnTranslate);
        Controls.Add(txtResult);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "3 хэлний толь бичиг";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.ComboBox cmbFrom;
    private System.Windows.Forms.ComboBox cmbTo;
    private System.Windows.Forms.Button btnSwap;
    private System.Windows.Forms.TextBox txtWord;
    private System.Windows.Forms.Button btnTranslate;
    private System.Windows.Forms.TextBox txtResult;
}