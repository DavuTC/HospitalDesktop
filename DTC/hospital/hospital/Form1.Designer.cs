namespace hospital
{
    partial class Form1
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1=new Label();
            label2=new Label();
            label3=new Label();
            label4=new Label();
            label5=new Label();
            button1=new Button();
            checkBox1=new CheckBox();
            button2=new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Comic Sans MS", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location=new Point(136, 25);
            label1.Margin=new Padding(4, 0, 4, 0);
            label1.Name="label1";
            label1.Size=new Size(334, 15);
            label1.TabIndex=0;
            label1.Text="Randevu Almadan önce Aşagıdakileri Okumanız Gerekmektedir..";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Font=new Font("Comic Sans MS", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location=new Point(43, 97);
            label2.Margin=new Padding(4, 0, 4, 0);
            label2.Name="label2";
            label2.Size=new Size(427, 15);
            label2.TabIndex=1;
            label2.Text="Muayene olacak kişinin T.C. Kimlik numarası 11 haneli ve doğru olarak girilmelidir.";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Font=new Font("Comic Sans MS", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location=new Point(44, 137);
            label3.Margin=new Padding(4, 0, 4, 0);
            label3.Name="label3";
            label3.Size=new Size(392, 15);
            label3.TabIndex=2;
            label3.Text="Başvuru sırasında sizden istenen Telefon numarası kısmını Lütfen Doldurun";
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Font=new Font("Comic Sans MS", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location=new Point(44, 178);
            label4.Margin=new Padding(4, 0, 4, 0);
            label4.Name="label4";
            label4.Size=new Size(494, 15);
            label4.TabIndex=3;
            label4.Text="Bazı bölümlerde (branşlarda) yaş sınırlamaları vardır.Randevu almadan okumanız tavsiye edilir..";
            // 
            // label5
            // 
            label5.AutoSize=true;
            label5.Font=new Font("Comic Sans MS", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location=new Point(44, 284);
            label5.Margin=new Padding(4, 0, 4, 0);
            label5.Name="label5";
            label5.Size=new Size(368, 15);
            label5.TabIndex=4;
            label5.Text="Uygun randevu bulunamadığı taktirde bir sonraki gün tekrar deneyiniz.";
            // 
            // button1
            // 
            button1.Font=new Font("Comic Sans MS", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location=new Point(136, 222);
            button1.Margin=new Padding(4, 4, 4, 4);
            button1.Name="button1";
            button1.Size=new Size(260, 30);
            button1.TabIndex=5;
            button1.Text="Yaş Sınırlamalarını Görmek İçin Tıklayın..";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize=true;
            checkBox1.Font=new Font("Comic Sans MS", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location=new Point(35, 328);
            checkBox1.Margin=new Padding(4, 4, 4, 4);
            checkBox1.Name="checkBox1";
            checkBox1.Size=new Size(404, 19);
            checkBox1.TabIndex=6;
            checkBox1.Text="Yukarıdaki bilgileri okudum, onaylıyorum. Şimdi randevu almak istiyorum. ";
            checkBox1.UseVisualStyleBackColor=true;
            checkBox1.CheckedChanged+=checkBox1_CheckedChanged;
            // 
            // button2
            // 
            button2.Font=new Font("Comic Sans MS", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location=new Point(124, 370);
            button2.Margin=new Padding(4, 4, 4, 4);
            button2.Name="button2";
            button2.Size=new Size(148, 30);
            button2.TabIndex=7;
            button2.Text="Randevu Al";
            button2.UseVisualStyleBackColor=true;
            button2.Click+=button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(7F, 17F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.FromArgb(0, 192, 192);
            ClientSize=new Size(657, 477);
            Controls.Add(button2);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin=new Padding(4, 4, 4, 4);
            Name="Form1";
            Text="Form1";
            Load+=Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private CheckBox checkBox1;
        private Button button2;
    }
}