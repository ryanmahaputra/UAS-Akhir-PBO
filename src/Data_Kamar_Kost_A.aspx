<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Data_Kamar_Kost_A.aspx.cs" Inherits="Kost_Q.src.Data_Kamar_Kost_A" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>KOST-Q</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.8.3/font/bootstrap-icons.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.1.1/css/all.min.css" integrity="sha512-KfkfwYDsLkIlwQp6LFnl8zNdLGxu9YAA1QvwINks4PhcElQSvqcyVLLD9aMhXd13uQjoXtEKNosOWaZqXgel0g==" crossorigin="anonymous" referrerpolicy="no-referrer" />
    <link href="style.css" rel="stylesheet" />
</head>
<body>

    <%-- HEADER --%>
    <header>
        <nav class="navbar navbar-expand-lg navbar-light" style="background-color: rgb(144, 174, 238);">
            <div class="container-fluid">
                <a class="navbar-brand ps-5 fs-3 ms-5">KOST-Q</a>
                <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <div class="collapse navbar-collapse" id="navbarSupportedContent">
                    <ul class="navbar-nav mb-2 mb-lg-0 w-75 ms-auto d-flex justify-content-between px-5">
                        <li class="nav-item ps-5">
                            <a class="nav-link active fs-2 ps-5" aria-current="page">Data Kamar Kost</a>
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
        <div class="container-fluid">

            <input type="checkbox" name="tbl-cek" id="cek2" />

            <label for="cek2">
                <i class="fa fa-bars fs-2 ms-5 p-1" id="keluar" style="background-color: rgb(144, 174, 238); border-radius: 5px;"></i>
                <i class="fa fa-bars fs-2 ms-5 p-1" id="masuk" style="background-color: rgb(144, 174, 238); border-radius: 5px;"></i>
            </label>

            <div class="sidebar" style="background-color: rgb(144, 174, 238);">
                <div class="judul-sidebar d-flex align-items-center justify-content-around mb-5 p-2" style="background-color: rgb(144, 174, 238); border: 3px solid black; margin-top: -2rem;">
                    <h2>Menu</h2>
                </div>
                <div class="konten-sidebar ps-4 text-dark">
                    <p class="fs-4">
                        <a href="Data_Kamar_Kost_A.aspx" class="text-dark" style="text-decoration: none;">Data Kamar Kost</a>
                    </p>
                    <p class="fs-4">
                        <a href="Data_Penyewa.aspx" class="text-dark" style="text-decoration: none;">Data Penyewa</a>
                    </p>
                    <p class="fs-4">
                        <a href="Laporan_Keuangan.aspx" class="text-dark" style="text-decoration: none;">Laporan Keuangan</a>
                    </p>
                    <p class="fs-4 text-dark">
                        <asp:Button Text="Keluar" ID="keluar_A" CssClass="text-dark border-0 bg-transparent" runat="server" OnClick="keluar_A_Click" />
                    </p>
                </div>
            </div>

            <div class="kamar-kost container pt-5">
                <div class="table-responsive">
                    <asp:PlaceHolder ID="info_data_kost_a" runat="server"></asp:PlaceHolder>
                </div>
            </div>
        </div>
    </form>

    <div class="tambah-data" style="position: absolute; bottom: 3rem; right: 5rem; border-radius: 50%;">
        <a href="Tambah_Data_Kamar.aspx" class="btn btn-warning" style="width: 80px; height: 80px; border-radius: 50%;">
            <i class="fa-solid fa-plus text-white" style="padding-top: 10%; font-size: 3.5rem;"></i>
        </a>
    </div>

</body>
</html>
