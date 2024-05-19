namespace RealArt
{
    partial class AuctionPaintingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            paintingsPanel = new TableLayoutPanel();
            panel1 = new Panel();
            MessageLabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // paintingsPanel
            // 
            paintingsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            paintingsPanel.AutoSize = true;
            paintingsPanel.ColumnCount = 3;
            paintingsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            paintingsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            paintingsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            paintingsPanel.Location = new Point(83, 61);
            paintingsPanel.Name = "paintingsPanel";
            paintingsPanel.RowCount = 1;
            paintingsPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 280F));
            paintingsPanel.Size = new Size(916, 280);
            paintingsPanel.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(MessageLabel);
            panel1.Controls.Add(paintingsPanel);
            panel1.Location = new Point(3, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1075, 644);
            panel1.TabIndex = 3;
            // 
            // MessageLabel
            // 
            MessageLabel.AutoSize = true;
            MessageLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MessageLabel.Location = new Point(246, 290);
            MessageLabel.Name = "MessageLabel";
            MessageLabel.Size = new Size(593, 48);
            MessageLabel.TabIndex = 3;
            MessageLabel.Text = "Жодної картини не було знайдено";
            // 
            // AuctionPaintingsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 644);
            Controls.Add(panel1);
            MaximumSize = new Size(1101, 700);
            MinimumSize = new Size(1101, 700);
            Name = "AuctionPaintingsForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Load += AuctionPaintingsForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel paintingsPanel;
        private Panel panel1;
        private Label MessageLabel;
    }
}