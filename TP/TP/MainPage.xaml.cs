using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.Title = "test";
        }

        public Boolean verifConnexion()
        {
            Boolean estConform = true;
            String[] errorMsg = new string[4];
            String identifiant = this.ident.Text.ToString();
            String pass = this.password.Text.ToString();
            if (identifiant.Length == 0)
            {
                errorMsg[0] = "Vous devez entrer une identifiant";
                estConform = false;
            }
            if (identifiant.Length < 3 && identifiant.Length > 0)
            {
                errorMsg[1] = "L'identifiant doit avoir minimum 3 caractères";
                estConform = false;
            }
            if (pass.Length == 0)
            {
                errorMsg[2] = "Vous devez entrer un mot de passe";
                estConform = false;
            }
            if (pass.Length < 6 && pass.Length > 0)
            {
                errorMsg[3] = "Le mot de passe doit avoir minimum 6 caractères";
                estConform = false;
            }
            foreach (var msg in errorMsg)
            {
                this.error.Text += msg + " "; 
            }
            return estConform;
        }
        public void confirm(object sender, EventArgs e)
        {
            this.error.Text = "";
            Person p = new Person ( "lio", "123456" );

            if (verifConnexion() && this.ident.Text.Equals(p.Identifiant) && this.password.Text.Equals(p.Password))
            {
                this.form.IsVisible =false;
                this.tweet.IsVisible =true;
            }
        }
    }
}
