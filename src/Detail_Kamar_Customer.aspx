<%@ Page Title="" Language="C#" MasterPageFile="~/src/Customer.Master" AutoEventWireup="true" CodeBehind="Detail_Kamar_Customer.aspx.cs" Inherits="Kost_Q.src.Detail_Kamar_Customer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="customer" runat="server">

    <div class="w-100 p-5">
        <div class="row">

            <asp:PlaceHolder ID="info_detail_kamar" runat="server"></asp:PlaceHolder>

            <div class="col-1">
                <a href="Data_Kamar_Kost_C.aspx" class="btn btn-info">
                    <i class="bi bi-arrow-left fs-4 text-dark"></i>
                </a>
            </div>
        </div>
    </div>

</asp:Content>
