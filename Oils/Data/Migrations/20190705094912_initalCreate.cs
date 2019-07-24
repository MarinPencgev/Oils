using Microsoft.EntityFrameworkCore.Migrations;

namespace Oils.Data.Migrations
{
    public partial class initalCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeliveryAddress_Receiver_ReceiverId",
                table: "DeliveryAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_Driver_Carrier_CarrierId",
                table: "Driver");

            migrationBuilder.DropForeignKey(
                name: "FK_Lot_Product_ProductId",
                table: "Lot");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Carrier_CarrierId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_DeliveryAddress_DeliveryAddressId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Driver_DriverId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Receiver_ReceiverId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Vehicle_VehicleId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderedProducts_Order_OrderId",
                table: "OrderedProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderedProducts_Product_ProductId",
                table: "OrderedProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Order_OrderId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_Carrier_CarrierId",
                table: "Vehicle");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vehicle",
                table: "Vehicle");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Receiver",
                table: "Receiver");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                table: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lot",
                table: "Lot");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Driver",
                table: "Driver");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DeliveryAddress",
                table: "DeliveryAddress");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Carrier",
                table: "Carrier");

            migrationBuilder.RenameTable(
                name: "Vehicle",
                newName: "Vehicles");

            migrationBuilder.RenameTable(
                name: "Receiver",
                newName: "Receivers");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "Order",
                newName: "Orders");

            migrationBuilder.RenameTable(
                name: "Lot",
                newName: "Lots");

            migrationBuilder.RenameTable(
                name: "Driver",
                newName: "Drivers");

            migrationBuilder.RenameTable(
                name: "DeliveryAddress",
                newName: "DeliveryAddresses");

            migrationBuilder.RenameTable(
                name: "Carrier",
                newName: "Carriers");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicle_CarrierId",
                table: "Vehicles",
                newName: "IX_Vehicles_CarrierId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_OrderId",
                table: "Products",
                newName: "IX_Products_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_VehicleId",
                table: "Orders",
                newName: "IX_Orders_VehicleId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_ReceiverId",
                table: "Orders",
                newName: "IX_Orders_ReceiverId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_DriverId",
                table: "Orders",
                newName: "IX_Orders_DriverId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_DeliveryAddressId",
                table: "Orders",
                newName: "IX_Orders_DeliveryAddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_CarrierId",
                table: "Orders",
                newName: "IX_Orders_CarrierId");

            migrationBuilder.RenameIndex(
                name: "IX_Lot_ProductId",
                table: "Lots",
                newName: "IX_Lots_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Driver_CarrierId",
                table: "Drivers",
                newName: "IX_Drivers_CarrierId");

            migrationBuilder.RenameIndex(
                name: "IX_DeliveryAddress_ReceiverId",
                table: "DeliveryAddresses",
                newName: "IX_DeliveryAddresses_ReceiverId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vehicles",
                table: "Vehicles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Receivers",
                table: "Receivers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lots",
                table: "Lots",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Drivers",
                table: "Drivers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DeliveryAddresses",
                table: "DeliveryAddresses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carriers",
                table: "Carriers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DeliveryAddresses_Receivers_ReceiverId",
                table: "DeliveryAddresses",
                column: "ReceiverId",
                principalTable: "Receivers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Drivers_Carriers_CarrierId",
                table: "Drivers",
                column: "CarrierId",
                principalTable: "Carriers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Lots_Products_ProductId",
                table: "Lots",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderedProducts_Orders_OrderId",
                table: "OrderedProducts",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderedProducts_Products_ProductId",
                table: "OrderedProducts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Carriers_CarrierId",
                table: "Orders",
                column: "CarrierId",
                principalTable: "Carriers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_DeliveryAddresses_DeliveryAddressId",
                table: "Orders",
                column: "DeliveryAddressId",
                principalTable: "DeliveryAddresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Drivers_DriverId",
                table: "Orders",
                column: "DriverId",
                principalTable: "Drivers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Receivers_ReceiverId",
                table: "Orders",
                column: "ReceiverId",
                principalTable: "Receivers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Vehicles_VehicleId",
                table: "Orders",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Orders_OrderId",
                table: "Products",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Carriers_CarrierId",
                table: "Vehicles",
                column: "CarrierId",
                principalTable: "Carriers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeliveryAddresses_Receivers_ReceiverId",
                table: "DeliveryAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Drivers_Carriers_CarrierId",
                table: "Drivers");

            migrationBuilder.DropForeignKey(
                name: "FK_Lots_Products_ProductId",
                table: "Lots");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderedProducts_Orders_OrderId",
                table: "OrderedProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderedProducts_Products_ProductId",
                table: "OrderedProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Carriers_CarrierId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_DeliveryAddresses_DeliveryAddressId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Drivers_DriverId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Receivers_ReceiverId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Vehicles_VehicleId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Orders_OrderId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Carriers_CarrierId",
                table: "Vehicles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vehicles",
                table: "Vehicles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Receivers",
                table: "Receivers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lots",
                table: "Lots");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Drivers",
                table: "Drivers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DeliveryAddresses",
                table: "DeliveryAddresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Carriers",
                table: "Carriers");

            migrationBuilder.RenameTable(
                name: "Vehicles",
                newName: "Vehicle");

            migrationBuilder.RenameTable(
                name: "Receivers",
                newName: "Receiver");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Product");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "Order");

            migrationBuilder.RenameTable(
                name: "Lots",
                newName: "Lot");

            migrationBuilder.RenameTable(
                name: "Drivers",
                newName: "Driver");

            migrationBuilder.RenameTable(
                name: "DeliveryAddresses",
                newName: "DeliveryAddress");

            migrationBuilder.RenameTable(
                name: "Carriers",
                newName: "Carrier");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicles_CarrierId",
                table: "Vehicle",
                newName: "IX_Vehicle_CarrierId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_OrderId",
                table: "Product",
                newName: "IX_Product_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_VehicleId",
                table: "Order",
                newName: "IX_Order_VehicleId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_ReceiverId",
                table: "Order",
                newName: "IX_Order_ReceiverId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_DriverId",
                table: "Order",
                newName: "IX_Order_DriverId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_DeliveryAddressId",
                table: "Order",
                newName: "IX_Order_DeliveryAddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_CarrierId",
                table: "Order",
                newName: "IX_Order_CarrierId");

            migrationBuilder.RenameIndex(
                name: "IX_Lots_ProductId",
                table: "Lot",
                newName: "IX_Lot_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Drivers_CarrierId",
                table: "Driver",
                newName: "IX_Driver_CarrierId");

            migrationBuilder.RenameIndex(
                name: "IX_DeliveryAddresses_ReceiverId",
                table: "DeliveryAddress",
                newName: "IX_DeliveryAddress_ReceiverId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vehicle",
                table: "Vehicle",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Receiver",
                table: "Receiver",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                table: "Order",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lot",
                table: "Lot",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Driver",
                table: "Driver",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DeliveryAddress",
                table: "DeliveryAddress",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carrier",
                table: "Carrier",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DeliveryAddress_Receiver_ReceiverId",
                table: "DeliveryAddress",
                column: "ReceiverId",
                principalTable: "Receiver",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Driver_Carrier_CarrierId",
                table: "Driver",
                column: "CarrierId",
                principalTable: "Carrier",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Lot_Product_ProductId",
                table: "Lot",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Carrier_CarrierId",
                table: "Order",
                column: "CarrierId",
                principalTable: "Carrier",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_DeliveryAddress_DeliveryAddressId",
                table: "Order",
                column: "DeliveryAddressId",
                principalTable: "DeliveryAddress",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Driver_DriverId",
                table: "Order",
                column: "DriverId",
                principalTable: "Driver",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Receiver_ReceiverId",
                table: "Order",
                column: "ReceiverId",
                principalTable: "Receiver",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Vehicle_VehicleId",
                table: "Order",
                column: "VehicleId",
                principalTable: "Vehicle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderedProducts_Order_OrderId",
                table: "OrderedProducts",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderedProducts_Product_ProductId",
                table: "OrderedProducts",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Order_OrderId",
                table: "Product",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_Carrier_CarrierId",
                table: "Vehicle",
                column: "CarrierId",
                principalTable: "Carrier",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
