<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ubah_Data_Kamar.aspx.cs" Inherits="Kost_Q.src.Ubah_Data_Kamar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>KOST-Q</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.8.3/font/bootstrap-icons.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.1.1/css/all.min.css" integrity="sha512-KfkfwYDsLkIlwQp6LFnl8zNdLGxu9YAA1QvwINks4PhcElQSvqcyVLLD9aMhXd13uQjoXtEKNosOWaZqXgel0g==" crossorigin="anonymous" referrerpolicy="no-referrer" />
    <style>
        .form-control {
            background-color: rgb(255, 239, 208); 
            border:none; 
            color:black;
        }
    </style>
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
                    <ul class="navbar-nav mb-2 mb-lg-0 w-25 ms-auto d-flex justify-content-between px-5">

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
                <div class="judul mb-5">
                    <h1 class="text-center">Ubah Data Kamar Kost</h1>
                </div>
                <div class="akses w-75 mx-auto row">
                    <div class="col-11">
                        <div class="mb-3 row">
                            <label for="nama_kamar" class="col-sm-2 col-form-label">Nama Kamar</label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="nama_kamar" CssClass="form-control" runat="server" />
                            </div>
                        </div>
                        <div class="mb-3 row">
                            <label for="status" class="col-sm-2 col-form-label">Status</label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="status" CssClass="form-control" runat="server" />
                            </div>
                        </div>
                        <div class="mb-3 row">
                            <label for="deskripsi" class="col-sm-2 col-form-label">Deskripsi</label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="deskripsi" CssClass="form-control" runat="server" />
                            </div>
                        </div>
                        <div class="mb-3 row">
                            <label for="harga" class="col-sm-2 col-form-label">Harga</label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="harga" CssClass="form-control" runat="server" />
                            </div>
                        </div>
                        <div class="tbl-login text-center mb-5">
                            <asp:Button Text="SUBMIT" ID="tbl_ubah_kamar" CssClass="btn btn-warning fs-5" runat="server" OnClick="tbl_ubah_kamar_Click" />
                        </div>
                    </div>
                    <div class="col-1">
                        <div class="kembali my-auto" style="padding-top: 350%;">
                            <a href="Data_Kamar_Kost_A.aspx" class="btn btn-info btn-lg text-dark">
                                <i class="bi bi-arrow-left fs-4"></i>
                            </a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>

</body>
</html>
