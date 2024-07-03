<%@ Page Title="Vertex | Home" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="student_eligibility_report.Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main class="container my-5">
        <section class="text-center mb-4">
            <img id="aspnetTitle" src="./Content/images/vertex-logo.svg" alt="Vertex Logo" style="height: 5vh;">
        </section>

        <div class="card shadow-sm">
            <div class="card-header text-center">
                <h2>Student Eligibility Report</h2>
            </div>
            <div class="card-header text-center">
                <h6>Please, type or print neatly.</h6>
                <h6>FORM 1. Side 1.</h6>
            </div>
            <div class="card-body">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="alert alert-danger" HeaderText="Please correct the following errors:" />

                <asp:Panel runat="server" DefaultButton="SubmitButton">
                    <div class="row mb-3">
                        <div class="col-md-6">
                            <label for="presentCollege" class="form-label">Your Present College</label>
                            <asp:TextBox ID="presentCollege" runat="server" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvPresentCollege" runat="server" ControlToValidate="presentCollege" ErrorMessage="Present College is required" CssClass="text-danger" Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>
                        <div class="col-md-6">
                            <label for="presentConference" class="form-label">Your Present Conference</label>
                            <asp:TextBox ID="presentConference" runat="server" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvPresentConference" runat="server" ControlToValidate="presentConference" ErrorMessage="Present Conference is required" CssClass="text-danger" Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>
                    </div>

                    <div class="row mb-3">
                        <div class="col-md-6">
                            <label for="name" class="form-label">Last Name, First, MI</label>
                            <asp:TextBox ID="name" runat="server" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="name" ErrorMessage="Name is required" CssClass="text-danger" Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>
                        <div class="col-md-6">
                            <label for="studentId" class="form-label">Student ID#</label>
                            <asp:TextBox ID="studentId" runat="server" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvStudentId" runat="server" ControlToValidate="studentId" ErrorMessage="Student ID is required" CssClass="text-danger" Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>
                    </div>

                    <div class="row mb-3">
                        <div class="col-md-6">
                            <label for="presentAddress" class="form-label">Present Address, Street, City, State, Zip Code</label>
                            <asp:TextBox ID="presentAddress" runat="server" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvPresentAddress" runat="server" ControlToValidate="presentAddress" ErrorMessage="Present Address is required" CssClass="text-danger" Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>
                        <div class="col-md-6">
                            <label for="telephone" class="form-label">Telephone #</label>
                            <asp:TextBox ID="telephone" runat="server" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvTelephone" runat="server" ControlToValidate="telephone" ErrorMessage="Telephone is required" CssClass="text-danger" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="revTelephone" runat="server" ControlToValidate="telephone" ErrorMessage="Invalid Telephone format" CssClass="text-danger" Display="Dynamic" ValidationExpression="^\+?\d+([-]?\d+)*$" ></asp:RegularExpressionValidator>
                        </div>
                    </div>

                    <div class="row mb-3">
                        <div class="col-md-6">
                            <label for="highSchool" class="form-label">High School Last Attended, City, State, Zip Code</label>
                            <asp:TextBox ID="highSchool" runat="server" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvHighSchool" runat="server" ControlToValidate="highSchool" ErrorMessage="High School Last Attended is required" CssClass="text-danger" Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>
                       <div class="col-md-3">
                            <label for="dob" class="form-label">Date of Birth (mm/dd/yy)</label>
                            <asp:TextBox ID="dob" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvDob" runat="server" ControlToValidate="dob" ErrorMessage="Date of Birth is required" CssClass="text-danger" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:CompareValidator ID="cvDob" runat="server" ControlToValidate="dob" Operator="DataTypeCheck" Type="Date" ErrorMessage="Invalid Date of Birth format" CssClass="text-danger" Display="Dynamic"></asp:CompareValidator>
                        </div>
                        <div class="col-md-3">
                            <label for="lastDateAttended" class="form-label">Last Date Attended (mm/dd/yy)</label>
                            <asp:TextBox ID="lastDateAttended" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvLastDateAttended" runat="server" ControlToValidate="lastDateAttended" ErrorMessage="Last Date Attended is required" CssClass="text-danger" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:CompareValidator ID="cvLastDateAttended" runat="server" ControlToValidate="lastDateAttended" Operator="DataTypeCheck" Type="Date" ErrorMessage="Invalid Last Date Attended format" CssClass="text-danger" Display="Dynamic"></asp:CompareValidator>
                        </div>
                    </div>

                    <div class="row mb-3">
                        <div class="col-md-6">
                            <label for="sport" class="form-label">Sport This Season</label>
                            <asp:DropDownList ID="sport" runat="server" CssClass="form-control">
                                <asp:ListItem Text="Choose" Value="" />
                                <asp:ListItem Text="Sport 1" Value="sport1" />
                                <asp:ListItem Text="Sport 2" Value="sport2" />
                            </asp:DropDownList>
                            <asp:RequiredFieldValidator ID="rfvSport" runat="server" ControlToValidate="sport" InitialValue="" ErrorMessage="Sport is required" CssClass="text-danger" Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>
                        <div class="col-md-6">
                          <label for="gender" class="form-label">Gender</label>
                          <asp:RadioButtonList ID="genderList" runat="server" CssClass="form-check">
                            <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
                            <asp:ListItem Text="Female" Value="Female"></asp:ListItem>
                          </asp:RadioButtonList>
                          <asp:RequiredFieldValidator ID="rfvGender" runat="server" ControlToValidate="genderList" InitialValue="" ErrorMessage="Gender is required" CssClass="text-danger" Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>
                    </div>

                    <div class="row mb-3">
                        <div class="col-md-12">
                            <label class="form-label">Previous Seasons of Competition Used in This Sport</label>
                            <asp:RadioButtonList ID="seasonList" runat="server" CssClass="form-check">
                            <asp:ListItem Text="0" Value="0"></asp:ListItem>
                            <asp:ListItem Text="1" Value="1"></asp:ListItem>
                            </asp:RadioButtonList>
                            <asp:RequiredFieldValidator ID="rfvSeason" runat="server" ControlToValidate="seasonList" InitialValue="" ErrorMessage="Season is required" CssClass="text-danger" Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>
                    </div>

                    <div class="row mb-3">
                        <div class="col-md-12">
                            <label class="form-label">Accurately account for all your time between high school graduation and the present.</label>
                            <asp:TextBox ID="timeAccount" runat="server" CssClass="form-control" TextMode="MultiLine" Rows="3"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvTimeAccount" runat="server" ControlToValidate="timeAccount" ErrorMessage="This field is required" CssClass="text-danger" Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>
                    </div>

                    <div class="row mb-3">
                        <div class="col-md-12">
                            <label class="form-label">Including this college and this season, list all of the colleges and sports in which you have practiced, scrimmaged, or competed, including club sports, JV, and varsity contests since high school:</label>
                            <asp:Table ID="sportsTable" runat="server" CssClass="table table-bordered">
                                <asp:TableHeaderRow>
                                    <asp:TableHeaderCell>Sport</asp:TableHeaderCell>
                                    <asp:TableHeaderCell>College</asp:TableHeaderCell>
                                    <asp:TableHeaderCell>Varsity/JV/Club</asp:TableHeaderCell>
                                    <asp:TableHeaderCell>Semester</asp:TableHeaderCell>
                                    <asp:TableHeaderCell>Year</asp:TableHeaderCell>
                                </asp:TableHeaderRow>
                                <asp:TableRow>
                                    <asp:TableCell><asp:TextBox runat="server" CssClass="form-control"></asp:TextBox></asp:TableCell>
                                    <asp:TableCell><asp:TextBox runat="server" CssClass="form-control"></asp:TextBox></asp:TableCell>
                                    <asp:TableCell><asp:TextBox runat="server" CssClass="form-control"></asp:TextBox></asp:TableCell>
                                    <asp:TableCell><asp:TextBox runat="server" CssClass="form-control"></asp:TextBox></asp:TableCell>
                                    <asp:TableCell><asp:TextBox runat="server" CssClass="form-control"></asp:TextBox></asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell><asp:TextBox runat="server" CssClass="form-control"></asp:TextBox></asp:TableCell>
                                    <asp:TableCell><asp:TextBox runat="server" CssClass="form-control"></asp:TextBox></asp:TableCell>
                                    <asp:TableCell><asp:TextBox runat="server" CssClass="form-control"></asp:TextBox></asp:TableCell>
                                    <asp:TableCell><asp:TextBox runat="server" CssClass="form-control"></asp:TextBox></asp:TableCell>
                                    <asp:TableCell><asp:TextBox runat="server" CssClass="form-control"></asp:TextBox></asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell><asp:TextBox runat="server" CssClass="form-control"></asp:TextBox></asp:TableCell>
                                    <asp:TableCell><asp:TextBox runat="server" CssClass="form-control"></asp:TextBox></asp:TableCell>
                                    <asp:TableCell><asp:TextBox runat="server" CssClass="form-control"></asp:TextBox></asp:TableCell>
                                    <asp:TableCell><asp:TextBox runat="server" CssClass="form-control"></asp:TextBox></asp:TableCell>
                                    <asp:TableCell><asp:TextBox runat="server" CssClass="form-control"></asp:TextBox></asp:TableCell>
                                </asp:TableRow>
                            </asp:Table>
                        </div>
                    </div>

                    <div class="text-center">
                        <asp:Button ID="SubmitButton" runat="server" Text="Submit" CssClass="btn btn-primary" OnClick="SubmitButton_Click"/>
                    </div>
                </asp:Panel>
            </div>
        </div>
    </main>
</asp:Content>