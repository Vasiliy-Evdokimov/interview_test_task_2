<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="test_app_web.frmMain" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel="stylesheet" href="css/styles.css"/>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        body {
            font-size: 10pt;
            font-family: Tahoma;
        }

        .backgroundColor {
            background-color: #666699;
            filter: alpha(opacity=50);
            opacity: 0.7;
        }

        .popupStyle {
            padding: 10px;
            border: 1px;
            border-style: solid;
            background-color: #d3ccc6;
            width: 450px;
        }

        .gridButton {
            width: 120px;
            margin: 2px;
            font-family: Tahoma;
        }

        .selectionColumn {
            width: 50px;
            text-align: center;
        }

        .popupGrid td:first-child {
            vertical-align: top;
            width: 150px;
        }

        .lblHidden {
            display: none;
        }
    </style>
</head>
<body>
    <form id="frmMain" runat="server">

        <asp:ScriptManager ID="smMain" runat="server"></asp:ScriptManager> 

        <asp:GridView ID="grdCustomer" runat="server" 
            AutoGenerateColumns="False"
            DataKeyNames="ID"            
            DataSourceID="sdsCustomer" 
            OnSelectedIndexChanged="grdCustomer_SelectedIndexChanged" OnDataBound="grdAccount_SelectedIndexChanged">
            <Columns>
                <asp:CommandField  ShowSelectButton="true" SelectText=">>" ItemStyle-CssClass="selectionColumn" >
                    <ItemStyle CssClass="selectionColumn"></ItemStyle>
                </asp:CommandField>
                <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" SortExpression="ID" InsertVisible="False" Visible="False" />
                <asp:BoundField DataField="Name" HeaderText="Название" SortExpression="Name" >
                    <ItemStyle Width="200px" />
                </asp:BoundField>
                <asp:BoundField DataField="INN" HeaderText="ИНН" SortExpression="INN" >
                    <ItemStyle Width="100px" />
                </asp:BoundField>
                <asp:BoundField DataField="Address" HeaderText="Адрес" SortExpression="Address" >
                    <ItemStyle Width="200px" />
                </asp:BoundField>
            </Columns>
            <HeaderStyle BackColor="#CCCCCC" BorderColor="Black" />
            <SelectedRowStyle BackColor="#0099CC" />
        </asp:GridView>
        <asp:SqlDataSource ID="sdsCustomer" runat="server" 
            ConnectionString="<%$ ConnectionStrings:test_dbConnectionString %>" 
            SelectCommand="SELECT * FROM [Customer]">
        </asp:SqlDataSource>

            <asp:Button ID="btnCustomerAdd" runat="server" OnClick="btnCustomerAdd_Click" Text="Добавить" CssClass="gridButton" />
            <asp:Button ID="btnCustomerEdit" runat="server" OnClick="btnCustomerEdit_Click" Text="Редактировать" CssClass="gridButton" />
            <asp:Button ID="btnCustomerDelete" runat="server" OnClick="btnCustomerDelete_Click" Text="Удалить" CssClass="gridButton" />
        <br />
        <br />

        <asp:Label ID="_lblCustomerName" runat="server" Text="Счета организации:"></asp:Label>&nbsp;
        <asp:Label ID="lblCustomerName" runat="server" Text="lblCustomerName" Font-Bold="True"></asp:Label>

        <br />
        <br />

        <asp:GridView ID="grdAccount" runat="server" 
            AutoGenerateColumns="False" 
            DataKeyNames="ID" 
            DataSourceID="sdsAccount" 
            OnSelectedIndexChanged="grdAccount_SelectedIndexChanged" OnDataBound="grdAccount_SelectedIndexChanged">
            <Columns>
                <asp:CommandField ShowSelectButton="true" SelectText=">>" ItemStyle-CssClass="selectionColumn" >
                    <ItemStyle CssClass="selectionColumn"></ItemStyle>
                </asp:CommandField>
                <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" Visible="False" />
                <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" SortExpression="CustomerID" Visible="False" />
                <asp:BoundField DataField="Account" HeaderText="Номер" SortExpression="Account" >
                    <ItemStyle Width="150px" />
                </asp:BoundField>
                <asp:BoundField DataField="Name" HeaderText="Название" SortExpression="Name" >
                    <ItemStyle Width="150px" />
                </asp:BoundField>
                <asp:BoundField DataField="BIK" HeaderText="БИК" SortExpression="BIK" >
                    <ItemStyle Width="150px" />
                </asp:BoundField>
                <asp:BoundField DataField="Balance" HeaderText="Остаток" SortExpression="Balance" >
                    <ItemStyle Width="150px" />
                </asp:BoundField>
            </Columns>
            <HeaderStyle BackColor="#CCCCCC" BorderColor="Black" />
            <SelectedRowStyle BackColor="#0099CC" />
        </asp:GridView>
        <asp:SqlDataSource ID="sdsAccount" runat="server" 
            ConnectionString="<%$ ConnectionStrings:test_dbConnectionString %>" 
            SelectCommand="SELECT * FROM Account WHERE CustomerID = @CustomerID">
            <SelectParameters>
                <asp:ControlParameter 
                    ControlID="grdCustomer" 
                    Name="CustomerID" 
                    PropertyName="SelectedDataKey.Values['ID']" />
            </SelectParameters>
        </asp:SqlDataSource>

        <asp:Button ID="btnAccountAdd" runat="server" OnClick="btnAccountAdd_Click" Text="Добавить" CssClass="gridButton" />
        <asp:Button ID="btnAccountEdit" runat="server" OnClick="btnAccountEdit_Click" Text="Редактировать" CssClass="gridButton" />
        <asp:Button ID="btnAccountDelete" runat="server" OnClick="btnAccountDelete_Click" Text="Удалить" CssClass="gridButton" />

        <br />
        <br />
        
        <asp:Panel ID="pnCustomer" runat="server" CssClass="popupStyle">                
              
            <h3 style="text-align: center;">
                <asp:Label ID="lblCustomerHeader" runat="server" Text="lblCustomerHeader"></asp:Label>                                
            </h3> 

            <div>
                <asp:Label ID="lblCustomerID" runat="server" Visible="False"></asp:Label>
            </div>

            <table class="popupGrid">
                <tr>
                    <td>
                        Название: 
                    </td>
                    <td>
                        <asp:TextBox ID="tbCustomerName" runat="server" Width="200px" />                          
                        <asp:RequiredFieldValidator ID="rfvCustomerName" runat="server" 
                            ErrorMessage="<br />Название обязательно"
                            ForeColor="Red" 
                            ControlToValidate="tbCustomerName" 
                            Display="Dynamic"
                            ValidationGroup="vgCustomer">
                        </asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revCustomerName" runat="server" 
                            ControlToValidate="tbCustomerName"
                            ForeColor="Red" 
                            Display="Dynamic" 
                            ErrorMessage="<br />Название на кириллице, макс. 100 символов"
                            ValidationGroup="vgCustomer"
                            ValidationExpression="^[?!,.а-яА-ЯёЁ0-9№\s]{1,100}$">
                        </asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        ИНН: 
                    </td>
                    <td>
                        <asp:TextBox ID="tbCustomerINN" runat="server" />         
                        <asp:RequiredFieldValidator ID="rfvCustomerINN" runat="server" 
                            ErrorMessage="<br />ИНН обязателен"
                            ForeColor="Red" 
                            ControlToValidate="tbCustomerINN" 
                            Display="Dynamic"
                            ValidationGroup="vgCustomer">
                        </asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator  ID="revCustomerINN" runat="server" 
                            ControlToValidate="tbCustomerINN"
                            ForeColor="Red" 
                            Display="Dynamic" 
                            ErrorMessage="<br />ИНН состоит из 12 цифр"
                            ValidationGroup="vgCustomer"
                            ValidationExpression="^\d{12}$">
                        </asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        Адрес:
                    </td>
                    <td>
                        <asp:TextBox ID="tbCustomerAddress" runat="server" Width="200px" />                              
                        <br />
                        <asp:RegularExpressionValidator  ID="revCustomerAddress" runat="server" 
                            ControlToValidate="tbCustomerAddress"
                            ForeColor="Red" 
                            Display="Dynamic" 
                            ErrorMessage="Максимальная длина адреса 255 символов"
                            ValidationGroup="vgCustomer"
                            ValidationExpression="^\w{0,255}$">
                        </asp:RegularExpressionValidator>
                    </td>
                </tr>
            </table>

            <p style="text-align: center;">
                <asp:Button ID="btnCustomerSave" runat="server" Text="Сохранить" OnClick="btnCustomerSave_Click"  
                    ValidationGroup="vgCustomer" CssClass="gridButton" />
                <asp:Button ID="btnCustomerCancel" runat="server" Text="Отмена" OnClick="btnCustomerCancel_Click" CssClass="gridButton" />
            </p>            
               
        </asp:Panel> 
        <ajaxToolKit:ModalPopupExtender ID="mpeCustomer" runat="server" 
            TargetControlID="lblHidden" 
            PopupControlID="pnCustomer"
            BackgroundCssClass="backgroundColor" 
            DropShadow="true" 
            PopupDragHandleControlID="header"/> 

        <!-- -------------------------------------- -->

        <asp:Panel ID="pnAccount" runat="server" CssClass="popupStyle">                
              
            <h3 style="text-align: center;">
                <asp:Label ID="lblAccountHeader" runat="server" Text="lblAccountHeader"></asp:Label>                
            </h3> 
            <div>
                <asp:Label ID="lblAccountCustomerID" runat="server" Visible="False"></asp:Label>
                <asp:Label ID="lblAccountID" runat="server" Visible="False"></asp:Label>
            </div>
                  
            <table class="popupGrid">
                <tr>
                    <td>
                        Номер счёта: 
                    </td>
                    <td>
                        <asp:TextBox ID="tbAccountNumber" runat="server" Width="200px" />                         
                        <asp:RequiredFieldValidator ID="rfvAccountNumber" runat="server" 
                            ErrorMessage="<br />Номер счета обязателен"
                            ForeColor="Red" 
                            ControlToValidate="tbAccountNumber" 
                            Display="Dynamic"
                            ValidationGroup="vgAccount">
                        </asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator  ID="revAccountNumber" runat="server" 
                            ControlToValidate="tbAccountNumber"
                            ForeColor="Red" 
                            Display="Dynamic" 
                            ErrorMessage="<br />Номер счёта состоит из 20 цифр"
                            ValidationGroup="vgAccount"
                            ValidationExpression="^\d{20}$">
                        </asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        Название:
                    </td>
                    <td>
                        <asp:TextBox ID="tbAccountName" runat="server" Width="200px" />                              
                        <asp:RegularExpressionValidator  ID="revAccountName" runat="server" 
                            ControlToValidate="tbAccountName"
                            ForeColor="Red" 
                            Display="Dynamic" 
                            ErrorMessage="<br />Название на кириллице, макс. 100 символов"
                            ValidationGroup="vgAccount"
                            ValidationExpression="^[?!,.а-яА-ЯёЁ0-9№\s]{0,100}$">
                        </asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        БИК:
                    </td>
                    <td>
                        <asp:TextBox ID="tbAccountBIK" runat="server" />             
                        <asp:RequiredFieldValidator ID="rfvAccountBIK" runat="server" 
                            ErrorMessage="<br />БИК обязателен"
                            ForeColor="Red" 
                            ControlToValidate="tbAccountBIK" 
                            Display="Dynamic"
                            ValidationGroup="vgAccount">
                        </asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="rveAccountBIK" runat="server" 
                            ControlToValidate="tbAccountBIK"
                            ForeColor="Red" 
                            Display="Dynamic" 
                            ErrorMessage="<br />БИК состоит из 9 цифр"
                            ValidationGroup="vgAccount"
                            ValidationExpression="^\d{9}$">
                        </asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        Остаток на счёте:
                    </td>
                    <td>
                        <asp:TextBox ID="tbAccountBalance" runat="server" />       
                        <asp:RequiredFieldValidator ID="rfvAccountBalance" runat="server" 
                            ErrorMessage="<br />Значение остатка обязательно"
                            ForeColor="Red" 
                            ControlToValidate="tbAccountBalance" 
                            Display="Dynamic"
                            ValidationGroup="vgAccount">
                        </asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="rveAccountBalance" runat="server" 
                            ControlToValidate="tbAccountBalance"
                            ForeColor="Red" 
                            Display="Dynamic" 
                            ErrorMessage="<br />Остаток должен быть числом"
                            ValidationGroup="vgAccount"
                            ValidationExpression="^\d*\,?\d+$">
                        </asp:RegularExpressionValidator>
                        <asp:RangeValidator ID="rvAccountBalance" runat="server" 
                            ControlToValidate="tbAccountBalance"
                            Type="Double" 
                            ErrorMessage="<br />Число от 0 до 999 999 999 999.99"                     
                            MinimumValue="0" 
                            MaximumValue="999999999999.99"                    
                            Display="Dynamic" 
                            ValidationGroup="vgAccount"
                            CultureInvariantValues="true"                    
                            ForeColor="Red">
                        </asp:RangeValidator>
                    </td>
                </tr>
            </table>           

            <p style="text-align: center;">
                <asp:Button ID="btnAccountSave" runat="server" Text="Сохранить" OnClick="btnAccountSave_Click"  
                    ValidationGroup="vgAccount" CssClass="gridButton" />
                <asp:Button ID="btnAccountCancel" runat="server" Text="Отмена" OnClick="btnAccountCancel_Click" CssClass="gridButton" />
            </p>
               
        </asp:Panel> 
        <ajaxToolKit:ModalPopupExtender ID="mpeAccount" runat="server" 
            TargetControlID="lblHidden" 
            PopupControlID="pnAccount"
            BackgroundCssClass="backgroundColor" 
            DropShadow="true" 
            PopupDragHandleControlID="header"/> 

        <asp:Label ID="lblHidden" runat="server" Text="lblHidden" CssClass="lblHidden"></asp:Label>

    </form>
</body>
</html>
