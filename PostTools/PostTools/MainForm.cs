/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2018/11/1
 * Time: 20:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Net;
using System.Text;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PostTools
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			tbx_domain.Text="http://localhost";
			tbx_port.Text="8888";
			tbx_url.Text="alert";
		}
		void Btn_sendClick(object sender, EventArgs e)
		{
			if(tbx_domain.Text==""||tbx_port.Text==""){
				MessageBox.Show("检查 Domain 和 Port 文本框。");
				return;
			}
			String url="";
			if(tbx_url.Text!=""){
				url=url+tbx_url.Text+"/";
			}
			if(tbx_port.Text!=""){
				url=":"+tbx_port.Text+"/"+url;
			}
			if(tbx_domain.Text!=""){
				url=tbx_domain.Text+url;
			}
			tbx_info.Text=url;
			PostMoths(url,tbx_data.Text);
		}
		
		public string PostMoths(string url, string param)
	    {
	        string strURL = url;
	        System.Net.HttpWebRequest request;
	        request = (System.Net.HttpWebRequest)WebRequest.Create(strURL);
	        request.Method = "POST";
	        request.ContentType = "application/json;charset=UTF-8";
	        string paraUrlCoded = param;
	        byte[] payload;
	        payload = System.Text.Encoding.UTF8.GetBytes(paraUrlCoded);
	        request.ContentLength = payload.Length;
	        Stream writer = request.GetRequestStream();
	        writer.Write(payload, 0, payload.Length);
	        writer.Close();
	        System.Net.HttpWebResponse response;
	        response = (System.Net.HttpWebResponse)request.GetResponse();
	        System.IO.Stream s;
	        s = response.GetResponseStream();
	        string StrDate = "";
	        string strValue = "";
	        StreamReader Reader = new StreamReader(s, Encoding.UTF8);
	        while ((StrDate = Reader.ReadLine()) != null)
	        {
	            strValue += StrDate + "\r\n";
	        }
	        return strValue;
	    }

	}
}
