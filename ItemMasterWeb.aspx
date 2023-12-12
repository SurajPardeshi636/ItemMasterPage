<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ItemMasterWeb.aspx.cs" Inherits="ItemMasterProject.ItemMasterWeb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>

    </title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: center; background-color: #C0C0C0; vertical-align: middle; line-height: normal;">

        <div class="Searchtbl" style="border: medium none #000000; width:85%; table-layout: auto; background-color: #66FF99; text-align: justify;" >
            <h3 style="background-color: #00FFFF; position: static; text-align: center">Search Data</h3>
            <br />
            <lable>Item Code</lable>
            <asp:DropDownList ID="DrpItemCode" runat="server" Width="170px" OnSelectedIndexChanged="DrpItemCode_SelectedIndexChanged" AutoPostBack="True"  >
            </asp:DropDownList>
            

            <lable>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Item Name</lable>
            <asp:DropDownList ID="DrpItemNamw" runat="server" Width="170px"  AutoPostBack="True" >
            </asp:DropDownList>
            

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            

            <asp:Button ID="Button1" runat="server" Text="Search" BackColor="#FF9999" OnClick="Button1_Click" />

        </div>






        <hr />

        
        
        
        
        
        
        
        
        
        
        <div style="border: medium none #000000; width:85%; background-color: #66FF99; table-layout: auto; border-collapse: separate; border-spacing: inherit; empty-cells: show; height: 246px;">
            <h3 style="text-align: center; background-color: #00FFFF; position: static">Item Information</h3>
            <lable>Item Category</lable>
            <asp:DropDownList ID="drpItemCat" runat="server"  Width="170px" AutoPostBack="True" OnSelectedIndexChanged="drpItemCat_SelectedIndexChanged" >
            </asp:DropDownList>

            
            <lable>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Item Subcategory</lable>
            <asp:DropDownList ID="drpItemSubCat" runat="server" Width="170px" AutoPostBack="True">
            </asp:DropDownList>
            
            <hr />

            <lable>Item Code</lable>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtItemCode" runat="server" Width="170px"></asp:TextBox>
            
            <lable>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Item Name</lable>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtItemName" runat="server" Width="170px"></asp:TextBox>
            <br />

            <lable>Manufacturer</lable>&nbsp;&nbsp;
            <asp:TextBox ID="txtManufacturer" runat="server" Width="170px"></asp:TextBox>
            
            <lable>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Material</lable>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtMaterial" runat="server" Width="170px"></asp:TextBox>
            <br />

            <lable>Item Type</lable>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtItemType" runat="server" Width="170px"></asp:TextBox>
            &nbsp;
            <lable>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Item SybType</lable>&nbsp;
            <asp:TextBox ID="txtItemSubType" runat="server" Width="170px"></asp:TextBox>
            <br />
            <lable>Color</lable>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtColor" runat="server" Width="170px"></asp:TextBox>
            <lable>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; UOM</lable>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtUOM" runat="server" Width="170px"></asp:TextBox>
            <br />
            <lable>HSN Code&nbsp;&nbsp;&nbsp;&nbsp; </lable>
            &nbsp;<asp:TextBox ID="txtHSNCode" runat="server" Width="170px"></asp:TextBox>
            <lable>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; GST Rate</lable>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtGSTRate" runat="server" Width="170px"></asp:TextBox>
            <br />
            <lable>Purchase Cost</lable>
            <asp:TextBox ID="txtPurchaseCost" runat="server" Width="170px"></asp:TextBox>
            <lable>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Selling Price</lable>&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtSellingPrice" runat="server" Width="170px"></asp:TextBox>
            <br />


        </div>
        <br />
        <br />
        <hr />

        <div style="border: 3px solid #800000; width:85%; align-items:center; text-align: center;">

            <asp:Button ID="btnSave" runat="server" Text="Save" BackColor="#6666FF" OnClick="btnSave_Click" />
            &nbsp;&nbsp;
            <asp:Button ID="btnUpdate" runat="server" Text="Update" BackColor="#FF9933" />
            &nbsp;&nbsp;
            <asp:Button ID="btnDelete" runat="server" Text="Delete" BackColor="Red" OnClick="btnDelete_Click"  />
        </div>
            </div>
    </form>
</body>
</html>
