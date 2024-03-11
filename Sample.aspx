<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Sample.aspx.cs" Inherits="Sample" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html lang="en" ng-app="Srfin">

<head runat="server">
    <meta charset="utf-8">
    <link rel="stylesheet" href="lib/bootstrap/css/bootstrap.min.css">
    <title>Tabla2</title>
</head>

<body>
    <nav class="navbar navbar-default"role="navigation">
        <div class="navbar-header">
            <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#nav-toggle">
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
            </button>
            <a class="navbar-brand" href="/">Administrador Supermercados</a>
        </div>
        <div class="collapse navbar-collapse" id="nav-toggle">
            <ul class="nav navbar-nav">
                <li class="active"><a href="/">Pedidos</a></li>
                <li><a href="/add">Sucursales</a></li>
            </ul>
            <form class="navbar-form navbar-right" role="search">
                <input type="text" class="form-control" placeholder="Search">
            </form>
        </div>
    </nav>

    <form id="form1" runat="server">
    <div class="container">
        <div class="page-header">
            <h2>Proyecto: <small>Supermercados</small></h2>
        </div>
        <div class="jumbotron">
            <h1>Hola, {{name || 'Usuario'}}</h1>
            <label for="name">Introduzca su nombre</label>
            <input type="text" ng-model="name" class="form-control input-lg" id="name">
        </div>
    </div>

    <input type="text" id="Text1" class="form-control" ng-model="contact.name">
    <asp:Button class="btn-lg" ID="Bt1" runat="server" onclick="Bt1_Click" Text="Base de Datos" />
    <asp:GridView class="container" ID="Tabla2" runat="server">     
    </asp:GridView>
    </form>

    <p>Id<input id="Submit1" type="submit" value="submit" /></p>
    <form>¿Cómo te llamas?
        <input type="text" ng-model="nombre">
    </form>
    <h1>Hola {{nombre}}</h1>
    <form>
        <input type="text" ng-model="valor">
    </form>

    <input type="button" value="Haz Click" ng-click="numero=2;otraCosa=dato" />

    <div ng-app ng-init="pensamientos=[];">
        <h1>Altavoz AngularJS</h1>
        <p>
            ¿Qué hay de nuevo?
            <br />
            <input type="text" ng-model="nuevoPensamiento" />
            <input type="button" value="agregar" ng-click="pensamientos.push(nuevoPensamiento); nuevoPensamiento='';" />
        </p>
        <h2>Pensamientos que has tenido</h2>
        <p ng-repeat="pensamiento in pensamientos" ng-init="paso=$index">
            Pensaste esto: {{pensamiento}} (Iteración con índice {{paso}})
        </p>
    </div>

    <div ng-controller="miControlador">
        <table>
            <thead>
                <tr>
                    <th>Id</th>
                    <th>Nombre</th>
                    <th>Apellido</th>
                    <th>Teléfono</th>
                    <th>Correo</th>
                </tr>
            </thead>
            <tbody>
                <tr ng-repeat="cliente in clientes">
                    <td>{{cliente.id}}</td>
                    <td>{{cliente.nombre}}</td>
                    <td>{{cliente.apellido}}</td>
                    <td>{{cliente.telefono}}</td>
                    <td>{{cliente.correo}}</td>
                </tr>
            </tbody>
        </table>
    </div>

    <h1 ng-class="vm.tamTitular">Acumulador</h1>
    <select mg-model="vm.tamTitular">
        <option value="titularpeq">Peque</option>
        <option value="tirulargran">Gran</optioin>
    </select>
    <p>{{vm.tamTitular}}</p>
    <h2 ng-class="vm.clases">Control de operación:</h2>
    ¿Cuánto? <input type="text" ng-model="vm.cuanto" size="4" placeholder="0" />
    <br />
    <input type="button" value="+" ng-click="sumar()" />
    <input type="button" value="-" ng-click="restar()" />
    <h2>Totales:</h2>
    <p ng-class="{positivo: vm.total >= 0, negativo: vm.total<0}">
        En acumulador llevamos <span>{{vm.total}}</span>
    </p>

    <script src="lib/jquery/src/jQuery-2.1.4.min.js"></script>
    <script src="lib/bootstrap/js/bootstrap.min.js"></script>
    <script type="text/javascript" src="lib/angular/angular.min.js"></script>
    <script type="text/javascript" src="AppJs/core/controller.js"></script>

</body>
</html>
