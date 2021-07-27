<%@ Page Title="" Language="C#" MasterPageFile="~/anonimo.Master" AutoEventWireup="true" CodeBehind="lerArtigo.aspx.cs" Inherits="GDocumental.lerArtigo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="conteudoPagina" runat="server">
            <!-- Page Header -->
    <!-- Set your background image for this header on the line below. -->
    <header class="intro-header" style="background-image: url('img/home-bg.jpg')">
        <div class="container">
            <div class="row">
                <div class="col-lg-8 col-lg-offset-2 col-md-10 col-md-offset-1">
                    <div class="site-heading">
                        <h1><%=docs._titulo %></h1>
                        <hr class="small">
                        <span class="subheading"><%=docs._descricao %></span>
                    </div>
                </div>
            </div>
        </div>
    </header>
    <!-- Main Content -->
    <div class="container">
        <div class="row">
            <div class="col-lg-8 col-lg-offset-2 col-md-10 col-md-offset-1">
                        <div class="post-preview">
                            <a href="lerArtigo.aspx?id=">
                                <h2 class="post-title">
                                    
                                </h2>
                                <h4 class="post-subtitle">
                                    <%=docs._resumo %>
                                </h4>
                            </a>
                            <p class="post-meta">Publicado por: <a href="#">&nbsp;<%=docs._autor %>&nbsp;</a>&nbsp;<%=docs._dtPublicacao %></p>
                        </div>
                        <hr>
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
