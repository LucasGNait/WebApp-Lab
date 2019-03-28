<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Lab Extended Information</h1>
    </div>

    <div class="row">
        <div class="col-md-6">
            <h2>Form Descriptions</h2>
            <div class="col-md-4">
                <h3>Form A</h3>
                <p>This form will be able to lookup and display a single row of data from a table, insert new rows into tables as well as update and delete rows in a table that either pre-exsist or that you added. This is a single item</p>
            </div>

            <div class="col-md-4">
                <h3>Form B</h3>
                <p>This form will display multiple rows of data from the Tables. This form will use "code-behind"</p>                
            </div>

            <div class="col-md-4">
                <h3>Form C</h3>
                <p>This provides a display of multiple rows as well but instead of using Code-behind it uses ObjectDataSource controls.</p>
            </div>

        </div>

        <div class="col-md-6">
            <h2>Known Bugs & Incompletions</h2>

            <div class="col-md-4">
                <h3>BUGS</h3>
                <p>
                    -No known bugs as known so far.
                </p>

            </div>
            
            <div class="col-md-4">
                <h3>Incompletions</h3>
                <p>-Havnt started on any of the forms as of yet.</p>
            </div>
                
           
        </div>

    </div>

        <div class="row">
            <div class="col-md-6">
                <h2>Entity Relationship diagram</h2>
                <p>
                    <img style="width: 60rem;" src="ERD.PNG" />
                </p>
            </div>

            <div class="col-md-6">
                <h2>Stored Procedures</h2>
                <ul>
                    <li>
                   -Assignments_FindByOffering - Returns zero or more Assignments records matching the offering id.
                    </li>
                    <li>
                   -CurrentOfferings_FindByCourse - Returns zero or more CurrentOfferings records matching the supplied course id.
                    </li>
                </ul>
            </div>
        </div>
    

</asp:Content>
