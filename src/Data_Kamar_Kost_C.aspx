<%@ Page Title="" Language="C#" MasterPageFile="~/src/Customer.Master" AutoEventWireup="true" CodeBehind="Data_Kamar_Kost_C.aspx.cs" Inherits="Kost_Q.src.Data_Kamar_Kost" %>

<asp:Content ID="Content1" ContentPlaceHolderID="customer" runat="server">

    <input type="checkbox" name="tbl-cek" id="cek2" />

    <label for="cek2">
        <i class="fa fa-bars fs-2 ms-5 p-1" id="keluar" style="background-color: rgb(144, 174, 238); border-radius: 5px;"></i>
        <i class="fa fa-bars fs-2 ms-5 p-1" id="masuk" style="background-color: rgb(144, 174, 238); border-radius: 5px;"></i>
    </label>

    <div class="sidebar" style="background-color: rgb(144, 174, 238);">
        <div class="judul-sidebar d-flex align-items-center justify-content-around mb-5 p-2" style="background-color: rgb(144, 174, 238); border: 3px solid black; margin-top: -2rem;">
            <h2>Menu</h2>
        </div>
        <div class="konten-sidebar ps-5 text-dark">
            <p class="fs-3">
                <a href="Data_Kamar_Kost_C.aspx" class="text-dark" style="text-decoration: none;">Kamar Kost</a>
            </p>
            <p class="fs-3 text-dark">
                <asp:Button Text="Keluar" ID="keluar_C" CssClass="text-dark border-0 bg-transparent" runat="server" OnClick="keluar_C_Click" />
            </p>
        </div>
    </div>

    <div class="kamar-kost container pt-5">
        <div class="table-responsive">

            <asp:PlaceHolder ID="info_data_kost_c" runat="server"></asp:PlaceHolder>

        </div>
    </div>

</asp:Content>
