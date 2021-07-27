<%@ Page Title="" Language="C#" MasterPageFile="~/anonimo.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="GDocumental.index" %>
<asp:Content ID="index" ContentPlaceHolderID="conteudoPagina" runat="server">
        <!-- Page Header -->
    <!-- Set your background image for this header on the line below. -->
    <header class="intro-header" style="background-image: url('img/home-bg.jpg')">
        <div class="container">
            <div class="row">
                <div class="col-lg-8 col-lg-offset-2 col-md-10 col-md-offset-1">
                    <div class="site-heading">
                        <h1>Docs 4 ALL</h1>
                        <hr class="small">
                        <span class="subheading">Um portal de Gestão Documental para Si (ou Ré)</span>
                    </div>
                </div>
            </div>
        </div>
    </header>

    <!-- Main Content -->
    <div class="container">
        <div class="row">
            <div class="col-lg-8 col-lg-offset-2 col-md-10 col-md-offset-1">
                <asp:Repeater ID="lstDocumentos" runat="server">
                    <ItemTemplate>
                        <div class="post-preview">
                            <a href="lerArtigo.aspx?id=<%# DataBinder.Eval(Container.DataItem, "uidDocumento") %>">
                                <h2 class="post-title">
                                    <%# DataBinder.Eval(Container.DataItem, "titulo") %>
                                </h2>
                                <h3 class="post-subtitle">
                                    <%# DataBinder.Eval(Container.DataItem, "resumo") %></i>
                                </h3>
                            </a>
                            <p class="post-meta">Publicado por: <a href="#"><%# DataBinder.Eval(Container.DataItem, "autor") %></a><%# DataBinder.Eval(Container.DataItem, "dtPublicacao") %></p>
                        </div>
                        <hr>
                    </ItemTemplate>
                </asp:Repeater>
                <!-- Artigo completo -->
                
                <!--Artigo completo -->
                <!-- Pager -->
                <ul class="pager">
                    <li class="next">
                        <a href="#">Publicações mais Antigas &rarr;</a>
                    </li>
                </ul>
            </div>
        </div>
    </div>
</asp:Content>
