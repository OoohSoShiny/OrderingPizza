
namespace PizzaOrder
{
    partial class MainFrame
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxTop = new System.Windows.Forms.GroupBox();
            this.groupBoxBottom = new System.Windows.Forms.GroupBox();
            this.btnCalculatePrice = new System.Windows.Forms.Button();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblCostNumber = new System.Windows.Forms.Label();
            this.radioButtonSmall = new System.Windows.Forms.RadioButton();
            this.radioButtonMedium = new System.Windows.Forms.RadioButton();
            this.radioButtonLarge = new System.Windows.Forms.RadioButton();
            this.checkBoxHackfleisch = new System.Windows.Forms.CheckBox();
            this.checkBoxSalami = new System.Windows.Forms.CheckBox();
            this.checkBoxSchinken = new System.Windows.Forms.CheckBox();
            this.checkBoxSpinat = new System.Windows.Forms.CheckBox();
            this.checkBoxOliven = new System.Windows.Forms.CheckBox();
            this.checkBoxPaprika = new System.Windows.Forms.CheckBox();
            this.checkBoxZwiebeln = new System.Windows.Forms.CheckBox();
            this.checkBoxThunfisch = new System.Windows.Forms.CheckBox();
            this.checkBoxPepperoni = new System.Windows.Forms.CheckBox();
            this.groupBoxTop.SuspendLayout();
            this.groupBoxBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTop
            // 
            this.groupBoxTop.Controls.Add(this.radioButtonLarge);
            this.groupBoxTop.Controls.Add(this.radioButtonMedium);
            this.groupBoxTop.Controls.Add(this.radioButtonSmall);
            this.groupBoxTop.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTop.Name = "groupBoxTop";
            this.groupBoxTop.Size = new System.Drawing.Size(306, 65);
            this.groupBoxTop.TabIndex = 0;
            this.groupBoxTop.TabStop = false;
            this.groupBoxTop.Text = "Pizzagröße";
            // 
            // groupBoxBottom
            // 
            this.groupBoxBottom.Controls.Add(this.checkBoxPepperoni);
            this.groupBoxBottom.Controls.Add(this.checkBoxThunfisch);
            this.groupBoxBottom.Controls.Add(this.checkBoxZwiebeln);
            this.groupBoxBottom.Controls.Add(this.checkBoxPaprika);
            this.groupBoxBottom.Controls.Add(this.checkBoxOliven);
            this.groupBoxBottom.Controls.Add(this.checkBoxSpinat);
            this.groupBoxBottom.Controls.Add(this.checkBoxSchinken);
            this.groupBoxBottom.Controls.Add(this.checkBoxSalami);
            this.groupBoxBottom.Controls.Add(this.checkBoxHackfleisch);
            this.groupBoxBottom.Location = new System.Drawing.Point(12, 94);
            this.groupBoxBottom.Name = "groupBoxBottom";
            this.groupBoxBottom.Size = new System.Drawing.Size(307, 139);
            this.groupBoxBottom.TabIndex = 1;
            this.groupBoxBottom.TabStop = false;
            this.groupBoxBottom.Text = "Beläge";
            // 
            // btnCalculatePrice
            // 
            this.btnCalculatePrice.Location = new System.Drawing.Point(13, 271);
            this.btnCalculatePrice.Name = "btnCalculatePrice";
            this.btnCalculatePrice.Size = new System.Drawing.Size(116, 23);
            this.btnCalculatePrice.TabIndex = 2;
            this.btnCalculatePrice.Text = "Preis berechnen";
            this.btnCalculatePrice.UseVisualStyleBackColor = true;
            this.btnCalculatePrice.Click += new System.EventHandler(this.btnCalculatePrice_Click);
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(13, 320);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(78, 13);
            this.lblCost.TabIndex = 3;
            this.lblCost.Text = "Gesamtkosten:";
            // 
            // lblCostNumber
            // 
            this.lblCostNumber.AutoSize = true;
            this.lblCostNumber.Location = new System.Drawing.Point(93, 320);
            this.lblCostNumber.Name = "lblCostNumber";
            this.lblCostNumber.Size = new System.Drawing.Size(0, 13);
            this.lblCostNumber.TabIndex = 4;
            // 
            // radioButtonSmall
            // 
            this.radioButtonSmall.AutoSize = true;
            this.radioButtonSmall.Location = new System.Drawing.Point(7, 20);
            this.radioButtonSmall.Name = "radioButtonSmall";
            this.radioButtonSmall.Size = new System.Drawing.Size(78, 17);
            this.radioButtonSmall.TabIndex = 0;
            this.radioButtonSmall.TabStop = true;
            this.radioButtonSmall.Text = "Klein (4,60)";
            this.radioButtonSmall.UseVisualStyleBackColor = true;
            // 
            // radioButtonMedium
            // 
            this.radioButtonMedium.AutoSize = true;
            this.radioButtonMedium.Location = new System.Drawing.Point(98, 19);
            this.radioButtonMedium.Name = "radioButtonMedium";
            this.radioButtonMedium.Size = new System.Drawing.Size(75, 17);
            this.radioButtonMedium.TabIndex = 1;
            this.radioButtonMedium.TabStop = true;
            this.radioButtonMedium.Text = "Groß(5,70)";
            this.radioButtonMedium.UseVisualStyleBackColor = true;
            // 
            // radioButtonLarge
            // 
            this.radioButtonLarge.AutoSize = true;
            this.radioButtonLarge.Location = new System.Drawing.Point(189, 19);
            this.radioButtonLarge.Name = "radioButtonLarge";
            this.radioButtonLarge.Size = new System.Drawing.Size(82, 17);
            this.radioButtonLarge.TabIndex = 2;
            this.radioButtonLarge.TabStop = true;
            this.radioButtonLarge.Text = "Party(12,50)";
            this.radioButtonLarge.UseVisualStyleBackColor = true;
            // 
            // checkBoxHackfleisch
            // 
            this.checkBoxHackfleisch.AutoSize = true;
            this.checkBoxHackfleisch.Location = new System.Drawing.Point(6, 20);
            this.checkBoxHackfleisch.Name = "checkBoxHackfleisch";
            this.checkBoxHackfleisch.Size = new System.Drawing.Size(82, 17);
            this.checkBoxHackfleisch.TabIndex = 0;
            this.checkBoxHackfleisch.Text = "Hackfleisch";
            this.checkBoxHackfleisch.UseVisualStyleBackColor = true;
            // 
            // checkBoxSalami
            // 
            this.checkBoxSalami.AutoSize = true;
            this.checkBoxSalami.Location = new System.Drawing.Point(99, 19);
            this.checkBoxSalami.Name = "checkBoxSalami";
            this.checkBoxSalami.Size = new System.Drawing.Size(57, 17);
            this.checkBoxSalami.TabIndex = 1;
            this.checkBoxSalami.Text = "Salami";
            this.checkBoxSalami.UseVisualStyleBackColor = true;
            // 
            // checkBoxSchinken
            // 
            this.checkBoxSchinken.AutoSize = true;
            this.checkBoxSchinken.Location = new System.Drawing.Point(190, 20);
            this.checkBoxSchinken.Name = "checkBoxSchinken";
            this.checkBoxSchinken.Size = new System.Drawing.Size(71, 17);
            this.checkBoxSchinken.TabIndex = 2;
            this.checkBoxSchinken.Text = "Schinken";
            this.checkBoxSchinken.UseVisualStyleBackColor = true;
            // 
            // checkBoxSpinat
            // 
            this.checkBoxSpinat.AutoSize = true;
            this.checkBoxSpinat.Location = new System.Drawing.Point(6, 64);
            this.checkBoxSpinat.Name = "checkBoxSpinat";
            this.checkBoxSpinat.Size = new System.Drawing.Size(56, 17);
            this.checkBoxSpinat.TabIndex = 3;
            this.checkBoxSpinat.Text = "Spinat";
            this.checkBoxSpinat.UseVisualStyleBackColor = true;
            // 
            // checkBoxOliven
            // 
            this.checkBoxOliven.AutoSize = true;
            this.checkBoxOliven.Location = new System.Drawing.Point(99, 64);
            this.checkBoxOliven.Name = "checkBoxOliven";
            this.checkBoxOliven.Size = new System.Drawing.Size(56, 17);
            this.checkBoxOliven.TabIndex = 4;
            this.checkBoxOliven.Text = "Oliven";
            this.checkBoxOliven.UseVisualStyleBackColor = true;
            // 
            // checkBoxPaprika
            // 
            this.checkBoxPaprika.AutoSize = true;
            this.checkBoxPaprika.Location = new System.Drawing.Point(190, 64);
            this.checkBoxPaprika.Name = "checkBoxPaprika";
            this.checkBoxPaprika.Size = new System.Drawing.Size(62, 17);
            this.checkBoxPaprika.TabIndex = 5;
            this.checkBoxPaprika.Text = "Paprika";
            this.checkBoxPaprika.UseVisualStyleBackColor = true;
            // 
            // checkBoxZwiebeln
            // 
            this.checkBoxZwiebeln.AutoSize = true;
            this.checkBoxZwiebeln.Location = new System.Drawing.Point(6, 106);
            this.checkBoxZwiebeln.Name = "checkBoxZwiebeln";
            this.checkBoxZwiebeln.Size = new System.Drawing.Size(69, 17);
            this.checkBoxZwiebeln.TabIndex = 6;
            this.checkBoxZwiebeln.Text = "Zwiebeln";
            this.checkBoxZwiebeln.UseVisualStyleBackColor = true;
            // 
            // checkBoxThunfisch
            // 
            this.checkBoxThunfisch.AutoSize = true;
            this.checkBoxThunfisch.Location = new System.Drawing.Point(99, 106);
            this.checkBoxThunfisch.Name = "checkBoxThunfisch";
            this.checkBoxThunfisch.Size = new System.Drawing.Size(73, 17);
            this.checkBoxThunfisch.TabIndex = 7;
            this.checkBoxThunfisch.Text = "Thunfisch";
            this.checkBoxThunfisch.UseVisualStyleBackColor = true;
            // 
            // checkBoxPepperoni
            // 
            this.checkBoxPepperoni.AutoSize = true;
            this.checkBoxPepperoni.Location = new System.Drawing.Point(190, 106);
            this.checkBoxPepperoni.Name = "checkBoxPepperoni";
            this.checkBoxPepperoni.Size = new System.Drawing.Size(74, 17);
            this.checkBoxPepperoni.TabIndex = 8;
            this.checkBoxPepperoni.Text = "Pepperoni";
            this.checkBoxPepperoni.UseVisualStyleBackColor = true;
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 345);
            this.Controls.Add(this.lblCostNumber);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.btnCalculatePrice);
            this.Controls.Add(this.groupBoxBottom);
            this.Controls.Add(this.groupBoxTop);
            this.Name = "MainFrame";
            this.Text = "Pizza Order";
            this.groupBoxTop.ResumeLayout(false);
            this.groupBoxTop.PerformLayout();
            this.groupBoxBottom.ResumeLayout(false);
            this.groupBoxBottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTop;
        private System.Windows.Forms.RadioButton radioButtonLarge;
        private System.Windows.Forms.RadioButton radioButtonMedium;
        private System.Windows.Forms.RadioButton radioButtonSmall;
        private System.Windows.Forms.GroupBox groupBoxBottom;
        private System.Windows.Forms.CheckBox checkBoxPepperoni;
        private System.Windows.Forms.CheckBox checkBoxThunfisch;
        private System.Windows.Forms.CheckBox checkBoxZwiebeln;
        private System.Windows.Forms.CheckBox checkBoxPaprika;
        private System.Windows.Forms.CheckBox checkBoxOliven;
        private System.Windows.Forms.CheckBox checkBoxSpinat;
        private System.Windows.Forms.CheckBox checkBoxSchinken;
        private System.Windows.Forms.CheckBox checkBoxSalami;
        private System.Windows.Forms.CheckBox checkBoxHackfleisch;
        private System.Windows.Forms.Button btnCalculatePrice;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblCostNumber;
    }
}

