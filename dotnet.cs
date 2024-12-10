
Title : Write a program to display even no and odd no using c#.
using System; class Programa
{
static void Main()
{
int start, end;

Console.Write("Enter the starting number :"); start = int.Parse(Console.ReadLine());

Console.Write("Enter the ending number : "); end = int.Parse(Console.ReadLine());

Console.WriteLine("\nEven numbers:"); for(int i = start; i<=end; i++)

{
if(i%2 == 0)
{
Console.Write(i + "");
}
}


Console.WriteLine("\nOdd numbers:"); for(int i = start; i<=end; i++)

{
if(i%2!=0)
{
Console.Write(i+" ");
}
}
Console.WriteLine(); Console.ReadLine();
}
}

// #########################################################################################################################################
// #########################################################################################################################################
// #########################################################################################################################################

 
Experiment No.2
Title : Write a program to demonstrate parameter passing mechanism and out parameter.
using System;

class ParameterPassingDemo
{


static void PassByValue(int a)
{
a = 10;
Console.WriteLine("Inside PassByValue, a = " + a);
}




static void PassByRef(ref int b)
{
b = 20;
Console.WriteLine("Inside PassByRef, b = " + b);
}




static void UsingOutParameter(out int c)
{
c = 30;
Console.WriteLine("Inside UsingOutParameter, c = " + c);
}


static void Main()
{
int x = 5; int y = 15; int z;

Console.WriteLine("Before PassByValue, x = " + x); PassByValue(x);
Console.WriteLine("After PassByValue, x = " + x);

Console.WriteLine("\nBefore PassByRef, y = " + y); PassByRef(ref y);
Console.WriteLine("After PassByRef, y = " + y);
 
UsingOutParameter(out z);
Console.WriteLine("After UsingOutParameter, z = " + z);

Console.WriteLine("Press any key to exit.."); Console.ReadLine();
}
}

// #########################################################################################################################################
// #########################################################################################################################################
// #########################################################################################################################################

 
Experiment No.3
Title : Write a program demonstrate type casting.
using System;

class TypecastingDemo
{
static void Main(string[] args)
{
int intNum = 100;
double doubleNum = intNum;

Console.WriteLine("Implicit Casting:"); Console.WriteLine("Integer:" + intNum); Console.WriteLine("Double:" + doubleNum);

double largeDouble = 123.45; int smallInt = (int)largeDouble;

Console.WriteLine("\nExplicit Casting:"); Console.WriteLine("Double:"+ largeDouble); Console.WriteLine("Covert to Integer:"+smallInt);

string strNum = "200";
int convertedInt = Convert.ToInt32(strNum);

Console.WriteLine("\nUsing Convert Class"); Console.WriteLine("String: " + strNum); Console.WriteLine("Converted to Integer: " + convertedInt);




int largeInt = 50000;
short smallShort = (short)largeInt;

Console.WriteLine("\nCasting with Potential Data Loss:"); Console.WriteLine("Integer: " + largeInt); Console.WriteLine("Converted to Short: " + smallShort); Console.ReadKey();
}
}
 

// #########################################################################################################################################
// #########################################################################################################################################
// #########################################################################################################################################

 
Experiment No.4
Title : Write a program to demonstrate partial class.
using System;

namespace Partial_Class
{
partial class Student
{
int rn;
string name;
public void Accept_Data()
{
Console.Write("Enter roll number : "); rn = int.Parse(Console.ReadLine()); Console.Write("Enter name : "); name = Console.ReadLine();
}
public void Display()
{
Console.WriteLine("Enter roll number : " + rn);

Console.WriteLine("Name :" + name);
}
}
partial class Student
{
int[] marks = new int[5]; int total_marks = 0; double percentage;

public void Get_marks()
{
for (int i = 0; i < 5; i++)
{
Console.WriteLine("Marks of subject -{0}:", i + 1); marks[i] = int.Parse(Console.ReadLine()); total_marks = total_marks + marks[i];
}
}
public void Put_marks()
{
for (int i = 0; i < 5; i++)
{
 
Console.WriteLine("Marks of subject -{0}:{1}", i + 1,marks[i]);
}
}
public void Display_Grade()
{
percentage = total_marks / 5.0; Console.WriteLine("Total Marks :" + total_marks); Console.WriteLine("Percentage :" + percentage + "%"); if (percentage >= 75)
{
Console.WriteLine("Congratulation!!! You have got Distinction");
}
else if (percentage >= 60 && percentage < 75)
{
Console.WriteLine("Congratulation!!! You have got First class");
}
else if (percentage >= 50 && percentage < 60)
{
Console.WriteLine("Congratulation!!! You have got Second class");
}
else if (percentage >= 40 && percentage < 50)
{
Console.WriteLine("Congratulation!!! You have got Higher Second class");
}
else
{
Console.WriteLine("Sorry...You have failed");
}
}
}
class Partial_class_Test
{
static void Main(string[] args)
{
Student ob = new Student(); ob.Accept_Data(); ob.Get_marks(); ob.Display(); ob.Put_marks(); ob.Display_Grade();

Console.ReadLine();
}
}
}
 

// #########################################################################################################################################
// #########################################################################################################################################
// #########################################################################################################################################



Experiment No.5
Title : Create web page using server controls- Text-box, List Controls, Calender, Imagebutten, Linkbutton.
Source Code :-
<html xmlns="http://www.w3.org/1999/xhtml">

<head id="Head1" runat="server">
<title>Student Registration Form</title>
<style type="text/css">
.form-title { color: #66ff66;
text-align: center;
font-size: xx-large;
}
.form-section {
margin: 20px 20px 20px 580px;
}
.form-label {
font-size: large;
}
.form-control {
font-size: medium; margin-left: 10px;
}
</style>
</head>
<body>
<form id="form1" runat="server">
<div class="form-title">
<h1 style="color: #FF33CC; font-style: italic; font-size: x-large; font-family: Arial, Helvetica, sans-serif; font-variant: normal; text-transform: capitalize; font-weight: normal;">Student Registration Form</h1>
</div>

<div class="form-section">
<asp:Label ID="LabelName" runat="server" CssClass="form-label" Text="Name:"></asp:Label>
<asp:TextBox ID="TextName" runat="server" CssClass="form-control" Width="300px"></asp:TextBox>
</div>
 

<div class="form-section">
<asp:Label ID="LabelDOB" runat="server" CssClass="form-label" Text="Date of Birth: "></asp:Label>
<asp:TextBox ID="TextDOB" runat="server" CssClass="form-control"
TextMode="Date" Width="200px"></asp:TextBox>
</div>

<div class="form-section">
<asp:Label ID="LabelEmail" runat="server" CssClass="form-label" Text="Email:"></asp:Label>
<asp:TextBox ID="TextEmail" runat="server" CssClass="form-control" Width="300px"></asp:TextBox>
</div>

<div class="form-section">
<asp:Label ID="LabelGender" runat="server" CssClass="form-label" Text="Gender:"></asp:Label>
<asp:RadioButtonList ID="RadioButtonListGender" runat="server"
CssClass="form-control">
<asp:ListItem Text="Male" Value="Male"></asp:ListItem>
<asp:ListItem Text="Female" Value="Female"></asp:ListItem>
<asp:ListItem Text="Other" Value="Other"></asp:ListItem>
</asp:RadioButtonList>
</div>

<div class="form-section">
<asp:Label ID="LabelPhone" runat="server" CssClass="form-label" Text="Phone Number:"></asp:Label>
<asp:TextBox ID="TextPhone" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
</div>

<div class="form-section">
<asp:Label ID="LabelCourse" runat="server" CssClass="form-label" Text="Select Course:"></asp:Label>
<asp:DropDownList ID="DDLCourse" runat="server" CssClass="form-control">
<asp:ListItem>-- Select Course --</asp:ListItem>
<asp:ListItem>Computer Science</asp:ListItem>
<asp:ListItem>Business Administration</asp:ListItem>
<asp:ListItem>Engineering</asp:ListItem>
<asp:ListItem>Mathematics</asp:ListItem>
</asp:DropDownList>
</div>

<div class="form-section">
 
<asp:Button ID="btnRegister" runat="server" Text="Register" />
</div>
</form>
</body>
</html>

// #########################################################################################################################################
// #########################################################################################################################################
// #########################################################################################################################################






Experiment No.6
Title: Develop ASP.Net Application through which user upload Image and that Image should be displayed in Image Control.
Image Uploading-
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="imageUpload.aspx.cs" Inherits="imageUpload" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title></title>
</head>
<body>
<form id="form1" runat="server">
<div>

<asp:Button ID="txtfile" runat="server" onclientclick="chooseFile_click" Text="Choose File:" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; No file choose&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Button ID="txtupload" runat="server" Text="Upload" />
<br />
<br />
<br />

</div>
<img alt="100+] Baby Cat Pictures | Wallpapers.com"
src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRFqyPM5rA3pVRYaExtw ZqW7StrPO5zQw230g&amp;s" /></form>
</body>
</html> 

// #########################################################################################################################################
// #########################################################################################################################################
// #########################################################################################################################################

 
 
Experiment No.7
Title : Write a program to create a web page showing use of following validation controls
Required field Range validation Compare validation Custom validation
Regular expression validation Validation summary
Source code-



<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="validation.aspx.cs" Inherits="WebApplication12.validation" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title></title>
</head>
<body>
<form id="form1" runat="server">
<div>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
<asp:Label ID="Label1" runat="server" ForeColor="#FF0066"
style="margin-left: 92px" Text="validation form" Width="299px"></asp:Label>
<asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True" />
<br />
 
<br />
<asp:Label ID="Label2" runat="server" Text="First Name"></asp:Label> &nbsp;&nbsp;
<asp:TextBox ID="FirstName" runat="server"></asp:TextBox> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="FirstName" Display="Dynamic" ErrorMessage="Please enter your name" ForeColor="Red"
SetFocusOnError="True"></asp:RequiredFieldValidator>
<br />
<br />
<asp:Label ID="Label3" runat="server" Text="Last Name"></asp:Label> &nbsp;&nbsp;&nbsp;
<asp:TextBox ID="LastName" runat="server"></asp:TextBox> &nbsp;&nbsp;&nbsp;&nbsp;
<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
ControlToValidate="LastName" Display="Dynamic" ErrorMessage="Please enter your last name"
ForeColor="Red"></asp:RequiredFieldValidator>
<br />
<br />
<asp:Label ID="Label4" runat="server" Text="DOB"></asp:Label> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:TextBox ID="TextBox1" runat="server" TextMode="Date"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox1" Display="Dynamic"
ErrorMessage="Please enter your DOB" ForeColor="Red">Please enter your DOB</asp:RequiredFieldValidator>
<br />
<br />
<asp:Label ID="Label5" runat="server" Text="Address"></asp:Label> &nbsp;&nbsp;&nbsp;
<asp:TextBox ID="Address" runat="server"></asp:TextBox> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="Address" Display="Dynamic" ErrorMessage="Please enter your Address"
ForeColor="Red"></asp:RequiredFieldValidator>
<br />
<br />
<asp:Label ID="Label6" runat="server" Text="Gender"></asp:Label> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
 
<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="Gender" Display="Dynamic" ErrorMessage="Please enter your Gender"
ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;<asp:RadioButtonList ID="Gender" runat="server" RepeatDirection="Horizontal">
<asp:ListItem>Male</asp:ListItem>
<asp:ListItem>Female</asp:ListItem>
</asp:RadioButtonList>
<br />
<asp:Label ID="Label7" runat="server" Text="Education"></asp:Label> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" ToolTip="Dropdownlist">
<asp:ListItem>Select</asp:ListItem>
<asp:ListItem>Graduction</asp:ListItem>
<asp:ListItem>PostGraduction</asp:ListItem>
<asp:ListItem>UnderGraduction</asp:ListItem>
</asp:DropDownList> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="DropDownList1" Display="Dynamic" ErrorMessage="Please enter your Education"
ForeColor="Red"></asp:RequiredFieldValidator>
<br />
<br />
<asp:Label ID="Label8" runat="server" Text="Age"></asp:Label> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:TextBox ID="Age" runat="server" ToolTip="txtage"></asp:TextBox> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="Age" Display="Dynamic" ErrorMessage="Please enter your
Age"
ForeColor="Red"></asp:RequiredFieldValidator>
<br />
<br />
<asp:Label ID="Label9" runat="server" Text="Password"></asp:Label> &nbsp;&nbsp;
<asp:TextBox ID="Password" runat="server" TextMode="Password" ViewStateMode="Enabled"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="Password" Display="Dynamic" ErrorMessage="Please enter your password"
ForeColor="Red"></asp:RequiredFieldValidator>
<br />
<br />
 
<asp:Label ID="Label10" runat="server" Text="Phone No"></asp:Label> &nbsp;
<asp:TextBox ID="PnoneNo" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="PnoneNo" Display="Dynamic" ErrorMessage="Please enter your Phone No"
ForeColor="Red"></asp:RequiredFieldValidator>
<br />
<br />
<asp:Button ID="Button1" runat="server" Text="Submit" />
</div>
</form>
</body>
</html>


// #########################################################################################################################################
// #########################################################################################################################################
// #########################################################################################################################################



 
Experiment No.9
Title: Write a program to create a web page showing use of response, redirect and server transfer.
source.aspx.cs

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="source.aspx.cs" Inherits="source" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title></title>
</head>
<body>
<p style="font-size: x-large; color: #003366; font-weight: normal; font-style: italic;"> &nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
This is source page&nbsp;
</p>
<form id="form1" runat="server">
<p style="margin-left: 160px">
<asp:Button ID="btnRedirect" runat="server" onclientclick="btnRedirect_Click" Text="Responce.Redirect" Width="240px" />
</p>
<p style="margin-left: 160px">
<asp:Button ID="btnTransfer" runat="server" onclientclick="btnTransfer_Click" Text="Server.Transfer" Visible="False" Width="237px" />
</p>
<p style="margin-left: 80px"> &nbsp;</p>
<p>
&nbsp;</p>
<p>
&nbsp;</p>
<p>
&nbsp;</p>
<div>

</div>
 
</form>
</body>
</html>
source_aspx.cs
using System;
using System.Collections.Generic; using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public class source_aspx :System.Web.UI.Page
{
protected void Page_Load(object sender, EventArgs e)
{

}
protected void btnRedirect_Click(object sender, EventArgs e)
{
Response.Redirect("Target.aspx");
}
protected void btnTransfer_Click(object sender, EventArgs e)
{
Server.Transfer("Target.aspx");
}
}
Target.aspx.cs
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Target.aspx.cs" Inherits="Target" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title></title>
</head>
<body>
<form id="form1" runat="server">
<div>
<strong>This is Target Page</strong>
</div>
</form>
</body>
</html>
 

// #########################################################################################################################################
// #########################################################################################################################################
// #########################################################################################################################################

 
Experiment No.10
Title: Develop a ASP>net Application for recording Registration details using different controls & validators
source.aspx.cs

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication14.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>Validator</title>
<style type="text/css">
.style1
{
width: 70%;
}
.style2
{
width: 290px; text-align: right;
}
.style3
{
text-align: left;
}
.style4
{
width: 290px; height: 23px; text-align: right;
}
.style5
{
text-align: left; height: 23px;
}
.style6
{
width: 290px; height: 30px;
 
text-align: right;
}
.style7
{
text-align: left; height: 30px;
}
</style>
</head>
<body>
<form id="form1" runat="server">
<div>
<center>
<h1>
Registration Form</h1>
</center>
</div>
<table align="center" class="style1">
<tr>
<td class="style4"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
Name:</td>
<td class="style5">
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="*Name is Empty"
ForeColor="#CC0000"></asp:RequiredFieldValidator>
</td>
</tr>
<tr>
<td class="style6">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
Password:&nbsp;</td>
<td class="style7">
<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="*Password is Blank" ForeColor="#CC0000"></asp:RequiredFieldValidator>
 
</td>
</tr>
<tr>
<td class="style2"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
Confirm Password:&nbsp;&nbsp;
</td>
<td class="style3">
<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="*Password is Empty" ForeColor="#CC0000"></asp:RequiredFieldValidator>
&nbsp;<asp:RangeValidator ID="RangeValidator1" runat="server"
ControlToValidate="TextBox3"
ErrorMessage="*Password doesn't Match" ForeColor="#3366FF"></asp:RangeValidator>
</td>
</tr>
<tr>
<td class="style6"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
Age:</td>
<td class="style7">
<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="*Enter Age"
ForeColor="#CC0000"></asp:RequiredFieldValidator>
<asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="TextBox4" ErrorMessage="*18&gt;&amp;&lt;30" ForeColor="#3366FF" MaximumValue="50"
MinimumValue="13"></asp:RangeValidator>
</td>
</tr>
<tr>
<td class="style2">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
Mobile.No:&nbsp;</td>
<td class="style3">
<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox5" ErrorMessage="*Enter mobile.no" ForeColor="#CC0000"></asp:RequiredFieldValidator>
<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
ControlToValidate="TextBox5" ErrorMessage="*Invalid Number"
ForeColor="Blue"
ValidationExpression="\d(10)"></asp:RegularExpressionValidator>
</td>
</tr>
<tr>
<td class="style2">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
&nbsp;</td>
<td class="style3">
<asp:Button ID="Button1" runat="server" Text="Register Now" />
</td>
</tr>
<tr>
<td class="style2"> &nbsp;</td>
<td class="style3">
<asp:ValidationSummary ID="ValidationSummary1" runat="server" />
</td>
</tr>
</table>
</form>
<p> &nbsp;
</p>
</body>
</html>


