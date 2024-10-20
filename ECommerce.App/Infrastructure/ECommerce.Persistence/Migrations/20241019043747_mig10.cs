using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerce.Persistence.Migrations
{
    public partial class mig10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_dinnerTables_restaurantBranches_BranchId",
                table: "dinnerTables");

            migrationBuilder.DropIndex(
                name: "IX_dinnerTables_BranchId",
                table: "dinnerTables");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "dinnerTables");

            migrationBuilder.AlterColumn<string>(
                name: "RestaurantBranchId",
                table: "dinnerTables",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c9d1dba-c977-471a-98c5-a2d5f04935c1",
                column: "ConcurrencyStamp",
                value: "3578c652-886f-4a4c-92ea-33fde2482f15");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1e3672e3-8563-49a3-8024-e36d2bf3dcb0",
                column: "ConcurrencyStamp",
                value: "78070f36-e02f-42f0-bbc8-fdfc1b6261ab");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e76c4fcf-4443-4cea-a649-576331c7603e",
                column: "ConcurrencyStamp",
                value: "f435c47c-7315-4881-8242-03b8dc9458c7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45121cfb-6a63-4950-9d67-68437d1bc43f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b542e846-e021-40ba-ac20-dd528e8ed23a", "AQAAAAEAACcQAAAAENJQQxBUFgsi/qugNZzA9mYeEGiT3d+NHMK2YuLnh0w1U8RT1pBEsOBuehKWabWk0A==", "033b4cfd-a2f0-4814-90a6-5f4af286caf3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7fc73959-cc3d-47d2-a017-dea6df68ae94",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a4d1552-6ac3-4b17-81ee-c28316392bc2", "AQAAAAEAACcQAAAAEB6xIAmnTHDgItouyUj5VhwoOnRgErJWn7YVlCO83n0VfHBTdRq/0Q/DxB5MLonmbw==", "32322ad6-7b54-4523-8ab8-482ad5575ff4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8fc73959-cc3d-47d2-a017-dea6df68ae94",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4cc7e3b2-6999-474b-95c1-b923c04c3a05", "AQAAAAEAACcQAAAAEPIsrOJqamHcWlMwfUuRR4x9B72M/2gFX5hFaLWohT3DJEKCj127RjcVAwenAIMxYQ==", "520474c6-5127-4dc5-bcd3-3892d8bbebaf" });

            migrationBuilder.InsertData(
                table: "resturants",
                columns: new[] { "Id", "Address", "CreateDate", "Email", "ImageUrl", "Name", "Phone", "UpdateDate" },
                values: new object[,]
                {
                    { "1a2b3c4d-5e6f-7g8h-9i0j-k1l2m3n4o5p6", "123 Main St, City, Country", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "info@restaurantA.com", "https://images.unsplash.com/photo-1509021436668-719bce81c2d5", "Restaurant A", "123-456-7890", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "2b3c4d5e-6f7g-8h9i-0j1k-2l3m4n5o6p7q", "456 Another St, City, Country", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "info@restaurantB.com", "https://images.unsplash.com/photo-1609001743548-0c2028d6b8d2", "Restaurant B", "987-654-3210", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "3c4d5e6f-7g8h-9i0j-k1l2-m3n4o5p6q7r", "789 Food St, City, Country", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "info@restaurantC.com", "https://images.unsplash.com/photo-1506794778163-1e31b24c0c66", "Restaurant C", "555-0123-4567", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "4d5e6f7g-8h9i-0j1k-2l3m-4n5o6p7q8r9", "101 Eatery Rd, City, Country", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "info@restaurantD.com", "https://images.unsplash.com/photo-1604901400781-67d71e7b7248", "Restaurant D", "654-321-0987", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "5e6f7g8h-9i0j-k1l2-m3n4-5o6p7q8r9s0", "202 Cuisine Ave, City, Country", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "info@restaurantE.com", "https://images.unsplash.com/photo-1568673228748-bb43f3a5ebaf", "Restaurant E", "321-654-9870", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "6f7g8h9i-0j1k-2l3m-4n5o-6p7q8r9s0t1", "303 Taste St, City, Country", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "info@restaurantF.com", "https://images.unsplash.com/photo-1589927986089-3581237894a4", "Restaurant F", "456-789-0123", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "7g8h9i0j-k1l2-m3n4-5o6p-7q8r9s0t1u2", "404 Flavor St, City, Country", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "info@restaurantG.com", "https://images.unsplash.com/photo-1543353071-6e0ffebc1b68", "Restaurant G", "789-012-3456", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "8h9i0j1k-2l3m-4n5o-6p7q-8r9s0t1u2v3", "505 Dish St, City, Country", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "info@restaurantH.com", "https://images.unsplash.com/photo-1601758167934-ec10e43c9c16", "Restaurant H", "321-987-6543", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "restaurantBranches",
                columns: new[] { "Id", "Address", "CreateDate", "Email", "ImageUrl", "Name", "Phone", "RestaurantId", "UpdateDate" },
                values: new object[,]
                {
                    { "1a1b1c1d-1e1f-1g1h-1i1j-1k1l1m1n1o1", "111 Branch St, City, Country", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "branchA1@restaurantA.com", "https://images.unsplash.com/photo-1589927986089-3581237894a4", "Branch A1", "321-654-9870", "1a2b3c4d-5e6f-7g8h-9i0j-k1l2m3n4o5p6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "2a2b2c2d-2e2f-2g2h-2i2j-2k2l2m2n2o2", "112 Branch St, City, Country", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "branchA2@restaurantA.com", "https://images.unsplash.com/photo-1610515162442-19625d0548c7", "Branch A2", "321-654-9871", "1a2b3c4d-5e6f-7g8h-9i0j-k1l2m3n4o5p6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "3a3b3c3d-3e3f-3g3h-3i3j-3k3l3m3n3o3", "222 Branch St, City, Country", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "branchB1@restaurantB.com", "https://images.unsplash.com/photo-1543353071-6e0ffebc1b68", "Branch B1", "654-321-9870", "2b3c4d5e-6f7g-8h9i-0j1k-2l3m4n5o6p7q", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "4a4b4c4d-4e4f-4g4h-4i4j-4k4l4m4n4o4", "223 Branch St, City, Country", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "branchB2@restaurantB.com", "https://images.unsplash.com/photo-1610515162442-19625d0548c7", "Branch B2", "654-321-9871", "2b3c4d5e-6f7g-8h9i-0j1k-2l3m4n5o6p7q", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "5a5b5c5d-5e5f-5g5h-5i5j-5k5l5m5n5o5", "333 Branch St, City, Country", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "branchC1@restaurantC.com", "https://images.unsplash.com/photo-1610515162442-19625d0548c7", "Branch C1", "987-123-4560", "3c4d5e6f-7g8h-9i0j-k1l2-m3n4o5p6q7r", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "6a6b6c6d-6e6f-6g6h-6i6j-6k6l6m6n6o6", "334 Branch St, City, Country", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "branchC2@restaurantC.com", "https://images.unsplash.com/photo-1610515162442-19625d0548c7", "Branch C2", "987-123-4561", "3c4d5e6f-7g8h-9i0j-k1l2-m3n4o5p6q7r", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "7a7b7c7d-7e7f-7g7h-7i7j-7k7l7m7n7o7", "444 Branch St, City, Country", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "branchD1@restaurantD.com", "https://images.unsplash.com/photo-1601758167934-ec10e43c9c16", "Branch D1", "789-456-1230", "4d5e6f7g-8h9i-0j1k-2l3m-4n5o6p7q8r9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "8a8b8c8d-8e8f-8g8h-8i8j-8k8l8m8n8o8", "445 Branch St, City, Country", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "branchD2@restaurantD.com", "https://images.unsplash.com/photo-1601758167934-ec10e43c9c16", "Branch D2", "789-456-1231", "4d5e6f7g-8h9i-0j1k-2l3m-4n5o6p7q8r9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "dinnerTables",
                columns: new[] { "Id", "Capacity", "CreateDate", "RestaurantBranchId", "TableName", "UpdateDate" },
                values: new object[,]
                {
                    { "1e1f1g1h-1i1j-1k1l-1m1n-1o1p1q1r1s1", 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1a1b1c1d-1e1f-1g1h-1i1j-1k1l1m1n1o1", "Table 1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "2e2f2g2h-2i2j-2k2l-2m2n-2o2p2q2r2s2", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2a2b2c2d-2e2f-2g2h-2i2j-2k2l2m2n2o2", "Table 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "3e3f3g3h-3i3j-3k3l-3m3n-3o3p3q3r3s3", 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3a3b3c3d-3e3f-3g3h-3i3j-3k3l3m3n3o3", "Table 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "4e4f4g4h-4i4j-4k4l-4m4n-4o4p4q4r4s4", 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4a4b4c4d-4e4f-4g4h-4i4j-4k4l4m4n4o4", "Table 4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "5e5f5g5h-5i5j-5k5l-5m5n-5o5p5q5r5s5", 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5a5b5c5d-5e5f-5g5h-5i5j-5k5l5m5n5o5", "Table 5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "6e6f6g6h-6i6j-6k6l-6m6n-6o6p6q6r6s6", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6a6b6c6d-6e6f-6g6h-6i6j-6k6l6m6n6o6", "Table 6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "7e7f7g7h-7i7j-7k7l-7m7n-7o7p7q7r7s7", 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7a7b7c7d-7e7f-7g7h-7i7j-7k7l7m7n7o7", "Table 7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "8e8f8g8h-8i8j-8k8l-8m8n-8o8p8q8r8s8", 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8a8b8c8d-8e8f-8g8h-8i8j-8k8l8m8n8o8", "Table 8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "timeSlots",
                columns: new[] { "Id", "CreateDate", "DinnerTableId", "MealType", "ReservationDay", "TableStatus", "UpdateDate" },
                values: new object[,]
                {
                    { "1g1h1i1j-1k1l-1m1n-1o1p-1q1r1s1t1u1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1e1f1g1h-1i1j-1k1l-1m1n-1o1p1q1r1s1", "Dinner", new DateTime(2024, 10, 19, 0, 0, 0, 0, DateTimeKind.Local), "Available", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "2g2h2i2j-2k2l-2m2n-2o2p-2q2r2s2t2u2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2e2f2g2h-2i2j-2k2l-2m2n-2o2p2q2r2s2", "Lunch", new DateTime(2024, 10, 20, 0, 0, 0, 0, DateTimeKind.Local), "Reserved", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "3g3h3i3j-3k3l-3m3n-3o3p-3q3r3s3t3u3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3e3f3g3h-3i3j-3k3l-3m3n-3o3p3q3r3s3", "Brunch", new DateTime(2024, 10, 19, 0, 0, 0, 0, DateTimeKind.Local), "Available", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "4g4h4i4j-4k4l-4m4n-4o4p-4q4r4s4t4u4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4e4f4g4h-4i4j-4k4l-4m4n-4o4p4q4r4s4", "Dinner", new DateTime(2024, 10, 20, 0, 0, 0, 0, DateTimeKind.Local), "Reserved", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "5g5h5i5j-5k5l-5m5n-5o5p-5q5r5s5t5u5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5e5f5g5h-5i5j-5k5l-5m5n-5o5p5q5r5s5", "Breakfast", new DateTime(2024, 10, 21, 0, 0, 0, 0, DateTimeKind.Local), "Available", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "6g6h6i6j-6k6l-6m6n-6o6p-6q6r6s6t6u6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6e6f6g6h-6i6j-6k6l-6m6n-6o6p6q6r6s6", "Lunch", new DateTime(2024, 10, 21, 0, 0, 0, 0, DateTimeKind.Local), "Reserved", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "7g7h7i7j-7k7l-7m7n-7o7p-7q7r7s7t7u7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7e7f7g7h-7i7j-7k7l-7m7n-7o7p7q7r7s7", "Dinner", new DateTime(2024, 10, 22, 0, 0, 0, 0, DateTimeKind.Local), "Available", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "8g8h8i8j-8k8l-8m8n-8o8p-8q8r8s8t8u8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8e8f8g8h-8i8j-8k8l-8m8n-8o8p8q8r8s8", "Brunch", new DateTime(2024, 10, 22, 0, 0, 0, 0, DateTimeKind.Local), "Reserved", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_dinnerTables_RestaurantBranchId",
                table: "dinnerTables",
                column: "RestaurantBranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_dinnerTables_restaurantBranches_RestaurantBranchId",
                table: "dinnerTables",
                column: "RestaurantBranchId",
                principalTable: "restaurantBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_dinnerTables_restaurantBranches_RestaurantBranchId",
                table: "dinnerTables");

            migrationBuilder.DropIndex(
                name: "IX_dinnerTables_RestaurantBranchId",
                table: "dinnerTables");

            migrationBuilder.DeleteData(
                table: "resturants",
                keyColumn: "Id",
                keyValue: "5e6f7g8h-9i0j-k1l2-m3n4-5o6p7q8r9s0");

            migrationBuilder.DeleteData(
                table: "resturants",
                keyColumn: "Id",
                keyValue: "6f7g8h9i-0j1k-2l3m-4n5o-6p7q8r9s0t1");

            migrationBuilder.DeleteData(
                table: "resturants",
                keyColumn: "Id",
                keyValue: "7g8h9i0j-k1l2-m3n4-5o6p-7q8r9s0t1u2");

            migrationBuilder.DeleteData(
                table: "resturants",
                keyColumn: "Id",
                keyValue: "8h9i0j1k-2l3m-4n5o-6p7q-8r9s0t1u2v3");

            migrationBuilder.DeleteData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: "1g1h1i1j-1k1l-1m1n-1o1p-1q1r1s1t1u1");

            migrationBuilder.DeleteData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: "2g2h2i2j-2k2l-2m2n-2o2p-2q2r2s2t2u2");

            migrationBuilder.DeleteData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: "3g3h3i3j-3k3l-3m3n-3o3p-3q3r3s3t3u3");

            migrationBuilder.DeleteData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: "4g4h4i4j-4k4l-4m4n-4o4p-4q4r4s4t4u4");

            migrationBuilder.DeleteData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: "5g5h5i5j-5k5l-5m5n-5o5p-5q5r5s5t5u5");

            migrationBuilder.DeleteData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: "6g6h6i6j-6k6l-6m6n-6o6p-6q6r6s6t6u6");

            migrationBuilder.DeleteData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: "7g7h7i7j-7k7l-7m7n-7o7p-7q7r7s7t7u7");

            migrationBuilder.DeleteData(
                table: "timeSlots",
                keyColumn: "Id",
                keyValue: "8g8h8i8j-8k8l-8m8n-8o8p-8q8r8s8t8u8");

            migrationBuilder.DeleteData(
                table: "dinnerTables",
                keyColumn: "Id",
                keyValue: "1e1f1g1h-1i1j-1k1l-1m1n-1o1p1q1r1s1");

            migrationBuilder.DeleteData(
                table: "dinnerTables",
                keyColumn: "Id",
                keyValue: "2e2f2g2h-2i2j-2k2l-2m2n-2o2p2q2r2s2");

            migrationBuilder.DeleteData(
                table: "dinnerTables",
                keyColumn: "Id",
                keyValue: "3e3f3g3h-3i3j-3k3l-3m3n-3o3p3q3r3s3");

            migrationBuilder.DeleteData(
                table: "dinnerTables",
                keyColumn: "Id",
                keyValue: "4e4f4g4h-4i4j-4k4l-4m4n-4o4p4q4r4s4");

            migrationBuilder.DeleteData(
                table: "dinnerTables",
                keyColumn: "Id",
                keyValue: "5e5f5g5h-5i5j-5k5l-5m5n-5o5p5q5r5s5");

            migrationBuilder.DeleteData(
                table: "dinnerTables",
                keyColumn: "Id",
                keyValue: "6e6f6g6h-6i6j-6k6l-6m6n-6o6p6q6r6s6");

            migrationBuilder.DeleteData(
                table: "dinnerTables",
                keyColumn: "Id",
                keyValue: "7e7f7g7h-7i7j-7k7l-7m7n-7o7p7q7r7s7");

            migrationBuilder.DeleteData(
                table: "dinnerTables",
                keyColumn: "Id",
                keyValue: "8e8f8g8h-8i8j-8k8l-8m8n-8o8p8q8r8s8");

            migrationBuilder.DeleteData(
                table: "restaurantBranches",
                keyColumn: "Id",
                keyValue: "1a1b1c1d-1e1f-1g1h-1i1j-1k1l1m1n1o1");

            migrationBuilder.DeleteData(
                table: "restaurantBranches",
                keyColumn: "Id",
                keyValue: "2a2b2c2d-2e2f-2g2h-2i2j-2k2l2m2n2o2");

            migrationBuilder.DeleteData(
                table: "restaurantBranches",
                keyColumn: "Id",
                keyValue: "3a3b3c3d-3e3f-3g3h-3i3j-3k3l3m3n3o3");

            migrationBuilder.DeleteData(
                table: "restaurantBranches",
                keyColumn: "Id",
                keyValue: "4a4b4c4d-4e4f-4g4h-4i4j-4k4l4m4n4o4");

            migrationBuilder.DeleteData(
                table: "restaurantBranches",
                keyColumn: "Id",
                keyValue: "5a5b5c5d-5e5f-5g5h-5i5j-5k5l5m5n5o5");

            migrationBuilder.DeleteData(
                table: "restaurantBranches",
                keyColumn: "Id",
                keyValue: "6a6b6c6d-6e6f-6g6h-6i6j-6k6l6m6n6o6");

            migrationBuilder.DeleteData(
                table: "restaurantBranches",
                keyColumn: "Id",
                keyValue: "7a7b7c7d-7e7f-7g7h-7i7j-7k7l7m7n7o7");

            migrationBuilder.DeleteData(
                table: "restaurantBranches",
                keyColumn: "Id",
                keyValue: "8a8b8c8d-8e8f-8g8h-8i8j-8k8l8m8n8o8");

            migrationBuilder.DeleteData(
                table: "resturants",
                keyColumn: "Id",
                keyValue: "1a2b3c4d-5e6f-7g8h-9i0j-k1l2m3n4o5p6");

            migrationBuilder.DeleteData(
                table: "resturants",
                keyColumn: "Id",
                keyValue: "2b3c4d5e-6f7g-8h9i-0j1k-2l3m4n5o6p7q");

            migrationBuilder.DeleteData(
                table: "resturants",
                keyColumn: "Id",
                keyValue: "3c4d5e6f-7g8h-9i0j-k1l2-m3n4o5p6q7r");

            migrationBuilder.DeleteData(
                table: "resturants",
                keyColumn: "Id",
                keyValue: "4d5e6f7g-8h9i-0j1k-2l3m-4n5o6p7q8r9");

            migrationBuilder.AlterColumn<int>(
                name: "RestaurantBranchId",
                table: "dinnerTables",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "BranchId",
                table: "dinnerTables",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c9d1dba-c977-471a-98c5-a2d5f04935c1",
                column: "ConcurrencyStamp",
                value: "e599ef4b-5ebf-43a3-841f-9a04a9e4337c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1e3672e3-8563-49a3-8024-e36d2bf3dcb0",
                column: "ConcurrencyStamp",
                value: "67cd53ee-341f-4e7c-a7b6-dc04b590bbfe");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e76c4fcf-4443-4cea-a649-576331c7603e",
                column: "ConcurrencyStamp",
                value: "a077feb2-b95c-496d-9a39-ead1b218afd4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45121cfb-6a63-4950-9d67-68437d1bc43f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "270b4b26-0968-4772-94b8-28f2a93508fe", "AQAAAAEAACcQAAAAEDojuzmCqujkQ/IA1dcKJ5M/Npm8SKEORnvi0KCPJHlZnpeM0Dt3Vus0nhGoem8X7w==", "88ea9e24-2b18-49b5-94c9-50ff48cae00a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7fc73959-cc3d-47d2-a017-dea6df68ae94",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cba4b786-0024-4dfa-9a5a-f79080a90d21", "AQAAAAEAACcQAAAAEM6EQkxcNYOX91brX9Wtm42ZH/v5YPsfSL9ECKqD+mNWrgQEO5Nk54v86qfODESN1g==", "022c9cf5-1b07-42cf-a322-2807688dea40" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8fc73959-cc3d-47d2-a017-dea6df68ae94",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d43093bc-8897-4474-9ffe-4f919d8b71b6", "AQAAAAEAACcQAAAAEMwL6bScHT1YvZ/XVq0mUATAQTLUOK9aVGmgqlSBDGOhLRYG71fBc4aFjfIkbUmEqQ==", "2131a03d-8e24-40fa-b6c1-45125a5233b0" });

            migrationBuilder.CreateIndex(
                name: "IX_dinnerTables_BranchId",
                table: "dinnerTables",
                column: "BranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_dinnerTables_restaurantBranches_BranchId",
                table: "dinnerTables",
                column: "BranchId",
                principalTable: "restaurantBranches",
                principalColumn: "Id");
        }
    }
}
