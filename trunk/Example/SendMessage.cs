/* --------------------------------------------------------------------------
 *
 * License
 *
 * The contents of this file are subject to the Jabber Open Source License
 * Version 1.0 (the "License").  You may not copy or use this file, in either
 * source code or executable form, except in compliance with the License.  You
 * may obtain a copy of the License at http://www.jabber.com/license/ or at
 * http://www.opensource.org/.  
 *
 * Software distributed under the License is distributed on an "AS IS" basis,
 * WITHOUT WARRANTY OF ANY KIND, either express or implied.  See the License
 * for the specific language governing rights and limitations under the
 * License.
 *
 * Copyrights
 * 
 * Portions created by or assigned to Cursive Systems, Inc. are 
 * Copyright (c) 2002 Cursive Systems, Inc.  All Rights Reserved.  Contact
 * information for Cursive Systems, Inc. is available at http://www.cursive.net/.
 *
 * Portions Copyright (c) 2002 Joe Hildebrand.
 * 
 * Acknowledgements
 * 
 * Special thanks to the Jabber Open Source Contributors for their
 * suggestions and support of Jabber.
 * 
 * --------------------------------------------------------------------------*/
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Example
{
    /// <summary>
    /// Summary description for SendMessage.
    /// </summary>
    public class SendMessage : System.Windows.Forms.Form
    {
        private jabber.client.JabberClient m_jc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtBody;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public SendMessage(jabber.client.JabberClient jc, string toJid) : this(jc)
        {
            txtTo.Text = toJid;
        }

        public SendMessage(jabber.client.JabberClient jc)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            m_jc = jc;
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose( bool disposing )
        {
            if( disposing )
            {
                if(components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose( disposing );
        }

                #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(SendMessage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                                 this.btnCancel,
                                                                                 this.btnSend,
                                                                                 this.txtSubject,
                                                                                 this.txtTo,
                                                                                 this.label2,
                                                                                 this.label1});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 72);
            this.panel1.TabIndex = 1;
            // 
            // txtBody
            // 
            this.txtBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBody.Location = new System.Drawing.Point(0, 72);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBody.Size = new System.Drawing.Size(312, 194);
            this.txtBody.TabIndex = 0;
            this.txtBody.Text = "";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "To:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Subject:";
            // 
            // txtTo
            // 
            this.txtTo.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
                | System.Windows.Forms.AnchorStyles.Right);
            this.txtTo.Location = new System.Drawing.Point(64, 9);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(184, 20);
            this.txtTo.TabIndex = 1;
            this.txtTo.Text = "";
            // 
            // txtSubject
            // 
            this.txtSubject.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
                | System.Windows.Forms.AnchorStyles.Right);
            this.txtSubject.Location = new System.Drawing.Point(64, 41);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(184, 20);
            this.txtSubject.TabIndex = 3;
            this.txtSubject.Text = "";
            // 
            // btnSend
            // 
            this.btnSend.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
            this.btnSend.Location = new System.Drawing.Point(256, 8);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(48, 23);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(256, 40);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(48, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SendMessage
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(312, 266);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                          this.txtBody,
                                                                          this.panel1});
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SendMessage";
            this.Text = "SendMessage";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
                #endregion

        private void btnSend_Click(object sender, System.EventArgs e)
        {
            jabber.protocol.client.Message msg = new jabber.protocol.client.Message(m_jc.Document);
            msg.To = txtTo.Text;
            if (txtSubject.Text != "")
                msg.Subject = txtSubject.Text;
            msg.Body = txtBody.Text;
            m_jc.Write(msg);
            this.Close();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}