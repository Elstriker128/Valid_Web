using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel.DataAnnotations;
using System.Web.Security;

namespace ValidWeb
{
    public partial class Forma1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (DropDownList1.Items.Count == 0)
            {
                DropDownList1.Items.Add("-");
                for (int i = 14; i <= 25; i++)
                {
                    DropDownList1.Items.Add(i.ToString());
                }
            }
            FirstData();
            for (int i = 0; i < Session.Count; i++)
            {
                Participant current = (Participant)Session[i.ToString()];
                TableDataInsert(current);
            }
            Label1.Text = (Session.Count).ToString();

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string Name = TextBox1.Text;
            string Surname = TextBox2.Text;
            string School = TextBox3.Text;
            string Age = DropDownList1.SelectedValue;
            string Languages = string.Empty;
            foreach(ListItem item in CheckBoxList1.Items)
            {
                if(item.Selected)
                {
                    if(Languages!=string.Empty)
                        Languages += "," + item.Text;
                    else
                        Languages = item.Text;
                }
            }

            Participant current = new Participant(Name,Surname,School,Age,Languages);

            Session[Session.Count.ToString()] = current;

            TableDataInsert(current);

            Label1.Text = (Session.Count).ToString();
        }
        private void FirstData()
        {

            TableRow row = new TableRow();

            TableCell name = new TableCell();
            name.Text = "Name";

            TableCell surname = new TableCell();
            surname.Text = "Surname";

            TableCell school = new TableCell();
            school.Text = "School";

            TableCell age = new TableCell();
            age.Text = "Age";

            TableCell languages = new TableCell();
            languages.Text = "Languages";

            row.Cells.Add(name);
            row.Cells.Add(surname);
            row.Cells.Add(school);
            row.Cells.Add(age);
            row.Cells.Add(languages);

            Table1.Rows.Add(row);
        }
        private void TableDataInsert(Participant participant)
        {

            TableRow row = new TableRow();

            TableCell name = new TableCell();
            name.Text = participant.Name;

            TableCell surname = new TableCell();
            surname.Text = participant.Surname;

            TableCell school = new TableCell();
            school.Text = participant.School;

            TableCell age = new TableCell();
            age.Text = participant.Age.ToString();

            TableCell languages = new TableCell();
            languages.Text = participant.Languages;

            row.Cells.Add(name);
            row.Cells.Add(surname);
            row.Cells.Add(school);
            row.Cells.Add(age); 
            row.Cells.Add(languages);

            Table1.Rows.Add(row);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Table1.Rows.Clear();
            Label1.Text= string.Empty;
        }
    }
    public class Participant
    {
        [Required]
        public string Name { get; private set; }
        [Required]
        public string Surname { get; private set; }
        [Required]
        public string School { get; private set; }
        [Required]
        public string Age { get; private set; }
        [Required]
        public string Languages { get; private set; }

        public Participant(string name, string surname, string school, string age, string languages)
        {
            Name = name;
            Surname = surname;
            School = school;
            Age = age;
            Languages = languages;
        }
    }
}