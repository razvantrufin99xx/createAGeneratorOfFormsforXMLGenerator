/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 9/4/2024
 * Time: 9:06 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace writeACreator
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
	
		}
		
		public string writeXMlHeader()
		{
			return "<?xml version='1.0' encoding='UTF-8'?>";
			
		}
		
		public List<Label> labels = new List<Label>();
		public List<TextBox> textboxes = new List<TextBox>();
		
		public void addLabelInList()
		{
			int c = labels.Count;
			labels.Add(new Label());
			this.Controls.Add(labels[c]);
			labels[c].Text = "Federatia";
			labels[c].Left = 50;
			labels[c].Top = 50;
			
			labels[c].Visible = true;
		}
		public void addTextBoxInList()
		{
			int c = textboxes.Count;
			textboxes.Add(new TextBox());
			this.Controls.Add(textboxes[c]);
			textboxes[c].Text = "FRF";
			textboxes[c].Left = 50;
			textboxes[c].Top = 80;
			
			labels[c].Visible = true;
		}
		void Button1Click(object sender, EventArgs e)
		{
			addLabelInList();
			addTextBoxInList();
		}
		void Button2Click(object sender, EventArgs e)
		{
			string sxml = writeXMlHeader() + "\r\n";
			sxml += "<federatia>" + "\r\n";
			sxml += "<denumire>" + textboxes[0].Text+"</denumire>"+"\r\n";
			sxml += "</federatia>" + "\r\n";
			
			Clipboard.SetText(sxml);
				
		}
		
		/*
		 <?xml version='1.0' encoding='UTF-8'?>
<federatia>
<denumire>FRF</denumire>
</federatia>

		 */
	}
}
