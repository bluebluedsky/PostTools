/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2018/11/1
 * Time: 20:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PostTools
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbx_domain;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbx_port;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbx_url;
		private System.Windows.Forms.TextBox tbx_data;
		private System.Windows.Forms.TextBox tbx_info;
		private System.Windows.Forms.Button btn_send;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.tbx_domain = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbx_port = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbx_url = new System.Windows.Forms.TextBox();
			this.tbx_data = new System.Windows.Forms.TextBox();
			this.tbx_info = new System.Windows.Forms.TextBox();
			this.btn_send = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Domain :";
			// 
			// tbx_domain
			// 
			this.tbx_domain.Location = new System.Drawing.Point(75, 10);
			this.tbx_domain.Name = "tbx_domain";
			this.tbx_domain.Size = new System.Drawing.Size(200, 21);
			this.tbx_domain.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(281, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Port :";
			// 
			// tbx_port
			// 
			this.tbx_port.Location = new System.Drawing.Point(323, 10);
			this.tbx_port.Name = "tbx_port";
			this.tbx_port.Size = new System.Drawing.Size(70, 21);
			this.tbx_port.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(410, 13);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "RawUrl :";
			// 
			// tbx_url
			// 
			this.tbx_url.Location = new System.Drawing.Point(474, 10);
			this.tbx_url.Name = "tbx_url";
			this.tbx_url.Size = new System.Drawing.Size(208, 21);
			this.tbx_url.TabIndex = 5;
			// 
			// tbx_data
			// 
			this.tbx_data.Location = new System.Drawing.Point(12, 39);
			this.tbx_data.Multiline = true;
			this.tbx_data.Name = "tbx_data";
			this.tbx_data.Size = new System.Drawing.Size(670, 404);
			this.tbx_data.TabIndex = 6;
			// 
			// tbx_info
			// 
			this.tbx_info.Location = new System.Drawing.Point(13, 449);
			this.tbx_info.Multiline = true;
			this.tbx_info.Name = "tbx_info";
			this.tbx_info.Size = new System.Drawing.Size(569, 53);
			this.tbx_info.TabIndex = 7;
			// 
			// btn_send
			// 
			this.btn_send.Location = new System.Drawing.Point(588, 479);
			this.btn_send.Name = "btn_send";
			this.btn_send.Size = new System.Drawing.Size(94, 23);
			this.btn_send.TabIndex = 8;
			this.btn_send.Text = "发送";
			this.btn_send.UseVisualStyleBackColor = true;
			this.btn_send.Click += new System.EventHandler(this.Btn_sendClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(694, 504);
			this.Controls.Add(this.btn_send);
			this.Controls.Add(this.tbx_info);
			this.Controls.Add(this.tbx_data);
			this.Controls.Add(this.tbx_url);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbx_port);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbx_domain);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "PostTools";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
