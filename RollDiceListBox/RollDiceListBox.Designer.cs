namespace RollDiceListBox
{
    partial class RollDiceListBox
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DisplayListBox = new ListBox();
            RollButton = new Button();
            ExitButton = new Button();
            ClearButton = new Button();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // DisplayListBox
            // 
            DisplayListBox.FormattingEnabled = true;
            DisplayListBox.Location = new Point(12, 8);
            DisplayListBox.Name = "DisplayListBox";
            DisplayListBox.Size = new Size(776, 264);
            DisplayListBox.TabIndex = 0;
            // 
            // RollButton
            // 
            RollButton.Location = new Point(335, 365);
            RollButton.Name = "RollButton";
            RollButton.Size = new Size(147, 73);
            RollButton.TabIndex = 1;
            RollButton.Text = "&Roll";
            toolTip1.SetToolTip(RollButton, "Rolls Dice 1000 times and shows the results");
            RollButton.UseVisualStyleBackColor = true;
            RollButton.Click += RollButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(641, 365);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(147, 73);
            ExitButton.TabIndex = 1;
            ExitButton.Text = "E&xit";
            toolTip1.SetToolTip(ExitButton, "Closes the Program");
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(488, 365);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(147, 73);
            ClearButton.TabIndex = 1;
            ClearButton.Text = "&Clear";
            toolTip1.SetToolTip(ClearButton, "Clears the Display");
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // RollDiceListBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ClearButton);
            Controls.Add(ExitButton);
            Controls.Add(RollButton);
            Controls.Add(DisplayListBox);
            Name = "RollDiceListBox";
            Text = "RollOfTheDiceListBox";
            ResumeLayout(false);
        }

        #endregion

        private ListBox DisplayListBox;
        private Button RollButton;
        private Button ExitButton;
        private Button ClearButton;
        private ToolTip toolTip1;
    }
}
