<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Data_Kamar_Detail.aspx.cs" Inherits="Kost_Q.src.Detail_Data_Kamar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>KOST-Q</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.8.3/font/bootstrap-icons.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.1.1/css/all.min.css" integrity="sha512-KfkfwYDsLkIlwQp6LFnl8zNdLGxu9YAA1QvwINks4PhcElQSvqcyVLLD9aMhXd13uQjoXtEKNosOWaZqXgel0g==" crossorigin="anonymous" referrerpolicy="no-referrer" />
</head>
<body>
    <%-- HEADER --%>
    <header>
        <nav class="navbar navbar-expand-lg navbar-light" style="background-color: rgb(144, 174, 238);">
            <div class="container-fluid">
                <a class="navbar-brand ps-5 fs-3">KOST-Q</a>
                <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <div class="collapse navbar-collapse" id="navbarSupportedContent">
                    <ul class="navbar-nav mb-2 mb-lg-0 w-75 ms-auto d-flex justify-content-between px-5">
                        <li class="nav-item ps-5">
                            <a class="nav-link active fs-2 ps-5" aria-current="page">Detail Data Kamar Kost</a>
                        </li>

                        <li class="nav-item d-flex align-items-center">
                            <i class="fa-solid fa-circle-user fs-1"></i>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>
    </header>
    <%-- HEADER --%>

    <form id="form1" runat="server">
        <div class="container-fluid mt-5 pt-5">
            <div class="container">

                <div class="row">
                    <asp:PlaceHolder ID="detail_kamar_a" runat="server"></asp:PlaceHolder>
                    <div class="col-2">
                        <div class="d-flex justify-content-between">
                            <div class="delete">
                                <asp:Button Text="HAPUS" CssClass="btn btn-danger btn-lg text-white" ID="hapus_kamar_a" runat="server" OnClick="hapus_kamar_a_Click" />
                            </div>
                            <div class="ubah">
                                <asp:PlaceHolder ID="edit_kamar" runat="server" />

                            </div>
                            <div class="kembali">
                                <a href="Data_Kamar_Kost_A.aspx" class="btn btn-info btn-lg text-dark">
                                    <i class="bi bi-arrow-left"></i>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </form>

</body>
</html>
