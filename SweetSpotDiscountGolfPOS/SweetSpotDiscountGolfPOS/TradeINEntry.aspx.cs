﻿using SweetShop;
using SweetSpotProShop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SweetSpotDiscountGolfPOS
{
    public partial class TradeINEntry : System.Web.UI.Page
    {
        Object o = new Object();
        SweetShopManager ssm = new SweetShopManager();
        Clubs c = new Clubs();
        ItemDataUtilities idu = new ItemDataUtilities();

        public int storeLocation = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            lblSKUDisplay.Text = idu.tradeInSku(storeLocation).ToString();
        }
        //Cancelling the trade-in item
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            string redirect = "<script>window.close('TradeINEntry.aspx');</script>";
            Response.Write(redirect);
        }
        //Finalizing the trade-in item
        protected void btnAddTradeIN_Click(object sender, EventArgs e)
        {
            //Grabbing the values of the trade-in item
            int sku = idu.tradeInSku(storeLocation);
            double cost = Convert.ToDouble(txtCost.Text);
            int brandID = Convert.ToInt32(ddlBrand.SelectedValue);
            int modelID = Convert.ToInt32(ddlModel.SelectedValue);
            int quant = Convert.ToInt32(txtQuantity.Text);
            string clubType = txtClubType.Text;
            string shaft = txtShaft.Text;
            string clubSpec = txtClubSpec.Text;
            string shaftFlex = txtShaftFlex.Text;
            string numOfClubs = txtNumberofClubs.Text;
            string shaftSpec = txtShaftSpec.Text;
            string dext = txtDexterity.Text;
            string comments = txtComments.Text;
            bool used = true; //Set to true because a trade-in item is used

            //Creating a new club
            Clubs tradeIN = new Clubs(sku, brandID, modelID, 1, clubType,
                shaft, numOfClubs, 0, cost, 0, quant, clubSpec, shaftSpec,
                shaftFlex, dext, used, comments);
            //Trade in club to be displayed
            Clubs tradeINDisplay = new Clubs(sku, brandID, modelID, 1, clubType,
                shaft, numOfClubs, 0, 0, (cost*(-1)), quant, clubSpec, shaftSpec,
                shaftFlex, dext, used, comments);
            //Adding the trade-in item to the trade-in storage
            idu.addTradeInItem(tradeIN);
            //Adding trade-in item to cart
            List<Cart> itemsInCart;
            itemsInCart = (List<Cart>)Session["ItemsInCart"];
            o = tradeINDisplay as Object;
            itemsInCart.Add(idu.addingToCart(o));
            Session["UpdateTheCart"] = true;
            //Closing the trade in information window
            string redirect = "<script>window.close('TradeINEntry.aspx');</script>";
            Response.Write(redirect);
        }
    }
}