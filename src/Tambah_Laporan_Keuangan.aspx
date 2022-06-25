<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tambah_Laporan_Keuangan.aspx.cs" Inherits="Kost_Q.src.Tambah_Laporan_Keuangan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>KOST-Q</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.8.3/font/bootstrap-icons.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.1.1/css/all.min.css" integrity="sha512-KfkfwYDsLkIlwQp6LFnl8zNdLGxu9YAA1QvwINks4PhcElQSvqcyVLLD9aMhXd13uQjoXtEKNosOWaZqXgel0g==" crossorigin="anonymous" referrerpolicy="no-referrer" />
    <style>
        .form-control 
        {
            background-color: rgb(255, 239, 208); 
            border: none; 
            color: black;
        }
    </style> 
</head>
<body>

    <%-- HEADER --%>
    <header>
        <nav class="navbar navbar-expand-lg navbar-light" style="background-color: rgb(144, 174, 238);">
            <div class="container-fluid">
                <a class="navbar-brand ps-5 fs-3" >KOST-Q</a>
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
                    <h1 class="text-center">Tambah Laporan Keuangan</h1>
                </div>
                <div class="akses w-75 mx-auto row">
                    <div class="col-11">
                        <div class="mb-4 row">
                            <label for="nama" class="col-sm-2 col-form-label">Nama</label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="nama" CssClass="form-control" AutoCompleteType="Disabled" runat="server" />
                            </div>
                        </div>
                        <div class="mb-4 row">
                            <label for="tanggal" class="col-sm-2 col-form-label">Tanggal <br />
                            <small style="font-size: 12px;">year - month - day</small>
                            </label>
                            
                            <div class="col-sm-10">
                                <asp:TextBox ID="tanggal" TextMode="Date" placeholder="yyyy-MM-dd"  CssClass="form-control" AutoCompleteType="Disabled" runat="server" />
                            </div>
                        </div>
                        <div class="mb-4 row">
                            <label for="keuntungan" class="col-sm-2 col-form-label">Keuntungan</label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="keuntungan" CssClass="form-control" AutoCompleteType="Disabled" runat="server" />
                            </div>
                        </div>
                        <div class="tbl-login text-center mb-5">
                            <asp:Button Text="SUBMIT" ID="tambah_keuangan" CssClass="btn btn-warning fs-5" runat="server" OnClick="tambah_keuangan_Click" />
                        </div>
                    </div>
                    <div class="col-1">
                        <div class="kembali my-auto" style="padding-top: 350%;">
                            <a href="Laporan_Keuangan.aspx" class="btn btn-info btn-lg text-dark">
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
