namespace DBMauiStudentEx;

public partial class StudentDetail : ContentPage
{
	public StudentDetail(Student passStudent)
	{
		InitializeComponent();
		passStudentName.Text = passStudent.Name;
    }


}