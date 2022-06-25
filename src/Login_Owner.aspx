<%@ Page Title="" Language="C#" MasterPageFile="~/src/Halaman.Master" AutoEventWireup="true" CodeBehind="Login_Owner.aspx.cs" Inherits="Kost_Q.src.Login_Owner" %>

<asp:Content ID="Content1" ContentPlaceHolderID="konten" runat="server">

    <div class="container mt-5">
        <div class="form-akses">
            <div class="judul-akses">
                <h1 class="fw-bold text-uppercase text-center">Login sebagai Owner
                </h1>
            </div>
            <div class="konten-input-form w-50 mx-auto mt-5">
                <div class="mb-3 row">
                    <label for="email" class="col-sm-2 col-form-label">Email</label>
                    <div class="col-sm-10">
                        <asp:TextBox ID="email" TextMode="Email" CssClass="form-control" runat="server" />
                    </div>
                </div>
                <div class="mb-3 row">
                    <label for="password" class="col-sm-2 col-form-label">Password</label>
                    <div class="col-sm-10">
                        <asp:TextBox ID="password" TextMode="Password" CssClass="form-control" runat="server" />
                    </div>
                </div>
                <div class="tbl-login text-center mb-5">
                    <asp:Button Text="LOGIN" ID="login_A" CssClass="btn btn-warning fs-5" runat="server"  OnClick="login_A_Click"  />
                </div>
                <div class="reg-to-log text-center">
                    <p>
                        Login sebagai Customer ?
                        <a href="Login_Customer.aspx" class="" style="text-decoration: none;">Klik Disini</a>
                    </p>
                </div>
                <div class="mt-5">
                    <div class="float-end">
                        <a href="" class="btn btn-info">
                            <i class="bi bi-arrow-left fs-4 text-dark"></i>
                        </a>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
