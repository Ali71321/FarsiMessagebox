using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;


namespace System.Windows.Forms
{
    public enum FarsiDialogResult
    {
        Yes, No, OK, Cancel, Abort, Retry, Ignore, Warning
    }

    public enum FarsiMessageBoxButtons
    {
        AbortRetryIgnore, OK, OKCancel, RetryCancel, YesNo, YesNoCancel
    }
    public enum FarsiMessageBoxTheme
    {
        Red, Blue, Gray
    }
    public enum FarsiMessageBoxIcons
    {
        Warning, Information, Error, Question, Stop
    }

    public partial class FarsiMessage : DevExpress.XtraEditors.XtraForm
    {
        public FarsiMessage()
        {
            InitializeComponent();
        }

        
        DialogResult _FarsiDialogResult;

        private DialogResult PersianResult
        {
            get { return _FarsiDialogResult; }
            set { _FarsiDialogResult = value; }
        }

        private Image  GetIcon(FarsiMessageBoxIcons MessageIcon)
        {
            switch (MessageIcon)
            {
                case FarsiMessageBoxIcons.Information:
                    return SystemIcons.Information.ToBitmap();
                case FarsiMessageBoxIcons.Warning:
                    return SystemIcons.Warning.ToBitmap();
                case FarsiMessageBoxIcons.Error:
                    return SystemIcons.Error.ToBitmap();
                case FarsiMessageBoxIcons.Question:
                    return SystemIcons.Question.ToBitmap();
                case FarsiMessageBoxIcons.Stop:
                    return SystemIcons.Hand.ToBitmap();
                    
            }
            return Properties.Resources.information;
        }

        private void SetButton(FarsiMessageBoxButtons MessageButton)
        {
            

            switch(MessageButton)
            {
                case FarsiMessageBoxButtons.AbortRetryIgnore:
                    btnOk.Visible = false;
                    
                    btnYes.Visible = false;
                    btnNo.Visible = false;
                    //btnAbort.Visible = true;
                    //btnRetry.Visible = true;
                    //btnIgnore.Visible = true;
                    //btnCancel.Visible = false;
                    //btnAbort.Left = groupBox1.Width - 106;
                    //btnRetry.Left = groupBox1.Width - 210;
                    //btnIgnore.Left = groupBox1.Width - 314;

                    break;

                case FarsiMessageBoxButtons.OK:
                    btnOk.Visible = true;
                   
                    btnYes.Visible = false;
                    btnNo.Visible = false;
                    //btnAbort.Visible = false;
                    //btnRetry.Visible = false;
                    //btnIgnore.Visible = false;
                    //btnCancel.Visible = false;
                    //btnOk.Left = groupBox1.Width - 106;


                    break;

                case FarsiMessageBoxButtons.OKCancel:
                    btnOk.Visible = true;
                    
                    btnYes.Visible = false;
                    btnNo.Visible = false;
                    //btnAbort.Visible = false;
                    //btnRetry.Visible = false;
                    //btnIgnore.Visible = false;
                    //btnCancel.Visible = true;
                    //btnOk.Left = groupBox1.Width - 106;
                    //btnCancel.Left = groupBox1.Width - 210;

                    break;

                case FarsiMessageBoxButtons.RetryCancel:
                    btnOk.Visible = false;
                   
                    btnYes.Visible = false;
                    btnNo.Visible = false;
                    //btnAbort.Visible = false;
                    //btnRetry.Visible = true;
                    //btnIgnore.Visible = false;
                    //btnCancel.Visible = true;
                    //btnRetry.Left = groupBox1.Width - 106;
                    //btnCancel.Left = groupBox1.Width - 210;
                    break;

                case FarsiMessageBoxButtons.YesNo:
                    btnOk.Visible = false;
                    
                    btnYes.Visible = true;
                    btnNo.Visible = true;
                    //btnAbort.Visible = false;
                    //btnRetry.Visible = false;
                    //btnIgnore.Visible = false;
                    //btnCancel.Visible = false;
                    //btnYes.Left = groupBox1.Width - 106;
                    //btnNo.Left = groupBox1.Width - 210;
                    break;

                case FarsiMessageBoxButtons.YesNoCancel:
                    btnOk.Visible = false;
                    
                    btnYes.Visible = true;
                    btnNo.Visible = true;
                    //btnAbort.Visible = false;
                    //btnRetry.Visible = false;
                    //btnIgnore.Visible = false;
                    //btnCancel.Visible = true;
                    //btnYes.Left = groupBox1.Width - 106;
                    //btnNo.Left = groupBox1.Width - 210;
                    //btnCancel.Left = groupBox1.Width - 314;
                    break;

            }
        }

        private void SetTheme(FarsiMessageBoxTheme Theme)
        {
            //switch(Theme)
            //{
            //    case PersianMessageBoxTheme.Blue:
            //        btnAbort.BackColor = btnCancel.BackColor = btnIgnore.BackColor = btnNo.BackColor = btnOk.BackColor = btnRetry.BackColor = btnYes.BackColor = this.BackColor = Color.Blue;
            //        break;
            //    case PersianMessageBoxTheme.Gray:
            //        btnAbort.BackColor = btnCancel.BackColor = btnIgnore.BackColor = btnNo.BackColor = btnOk.BackColor = btnRetry.BackColor = btnYes.BackColor = this.BackColor = Color.Gainsboro;
            //        break;
            //    case PersianMessageBoxTheme.Red:
            //        btnAbort.BackColor = btnCancel.BackColor = btnIgnore.BackColor = btnNo.BackColor = btnOk.BackColor = btnRetry.BackColor = btnYes.BackColor = this.BackColor = Color.Red;
            //        break;
            //}
        }

        private void GetSound(FarsiMessageBoxIcons MessageIcon)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            switch(MessageIcon)
            {
                case FarsiMessageBoxIcons.Error:
                    System.Media.SystemSounds.Hand.Play();
                    break;
                case FarsiMessageBoxIcons.Information:
                    System.Media.SystemSounds.Asterisk.Play();
                    break;
                case FarsiMessageBoxIcons.Question:
                    System.Media.SystemSounds.Question.Play();
                    
                    break;
                case FarsiMessageBoxIcons.Warning:
                    System.Media.SystemSounds.Exclamation.Play();
                    break;

                case FarsiMessageBoxIcons.Stop:
                    System.Media.SystemSounds.Hand.Play();
                    
                    break;
            }
        }

        public static DialogResult Show(string Message)
        {
            FarsiMessage Bax = new FarsiMessage();
            Bax.Text = " ";
            Bax.lblText.Text = Message;
            Bax.SetButton(FarsiMessageBoxButtons.OK);
            Bax.SetTheme(FarsiMessageBoxTheme.Gray);
            Bax.ShowDialog();
            return Bax._FarsiDialogResult;
        }

        public static DialogResult Show(string Message, string Title)
        {
            FarsiMessage Bax = new FarsiMessage();
            Bax.Text = Title;
            Bax.lblText.Text = Message;
            Bax.SetButton(FarsiMessageBoxButtons.OK);
            Bax.SetTheme(FarsiMessageBoxTheme.Gray);
            Bax.ShowDialog();
            return Bax._FarsiDialogResult;
        }
        public static DialogResult Show(string Message, string Title, FarsiMessageBoxButtons MessageButton)
        {
            FarsiMessage Bax = new FarsiMessage();
            Bax.Text = Title;
            Bax.lblText.Text = Message;
            Bax.SetButton(MessageButton);
            Bax.SetTheme(FarsiMessageBoxTheme.Gray);
            Bax.ShowDialog();
            return Bax._FarsiDialogResult;
        }
        public static DialogResult Show(string Message, string Title, FarsiMessageBoxButtons MessageButton, FarsiMessageBoxIcons MessageIcon)
        {
            FarsiMessage Bax = new FarsiMessage();
            Bax.Text = Title;
            Bax.lblText.Text = Message;
            Bax.SetButton(MessageButton);
            Bax.pbxIcon.Image = Bax.GetIcon(MessageIcon);
            Bax.GetSound(MessageIcon);
            Bax.SetTheme(FarsiMessageBoxTheme.Gray);
            Bax.ShowDialog();
            return Bax._FarsiDialogResult;
        }
        public static DialogResult Show(string Message, string Title, FarsiMessageBoxButtons MessageButton, FarsiMessageBoxIcons MessageIcon, FarsiMessageBoxTheme Theme)
        {
            FarsiMessage Bax = new FarsiMessage();
            Bax.Text = Title;
            Bax.lblText.Text = Message;
            Bax.SetButton(MessageButton);
            Bax.pbxIcon.Image = Bax.GetIcon(MessageIcon);
            Bax.GetSound(MessageIcon);
            Bax.SetTheme(Theme);
            Bax.ShowDialog();
            return Bax._FarsiDialogResult;
        }


        #region Btns


        private void label1_Click(object sender, EventArgs e)
        {
         
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            PersianResult = DialogResult.OK;
            this.Close();
        }

        

        private void ShowMessage_Load(object sender, EventArgs e)
        {

        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            PersianResult = DialogResult.Yes;
            this.Close();
        }

       

        private void btnNo_Click(object sender, EventArgs e)
        {
            PersianResult = DialogResult.No;
            this.Close();
        }

        //private void btnAbort_Click(object sender, EventArgs e)
        //{
        //    PersianResult = DialogResult.Abort;
        //    this.Close();
        //}

        //private void btnCancel_Click(object sender, EventArgs e)
        //{
        //    PersianResult = DialogResult.Cancel;
        //    this.Close();
        //}
        //private void btnRetry_Click(object sender, EventArgs e)
        //{
        //    PersianResult = DialogResult.Retry;
        //    this.Close();
        //}
        //private void btnIgnore_Click(object sender, EventArgs e)
        //{
        //    PersianResult = DialogResult.Ignore;
        //    this.Close();
        //}

        #endregion

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            pbxIcon.Image?.Dispose();
            pbxIcon.Image = null;
            base.OnFormClosed(e);
        }

        private void lblText_Click(object sender, EventArgs e)
        {

        }
    }
}
