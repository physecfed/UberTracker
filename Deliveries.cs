/* File:        Deliveries.cs
 * Project:     UberTracker
 * Author:      E. C. Fedele
 * Date:        October 1, 2022
 * Description: The Deliveries class implements the main logic of the UberTracker program - it is the hub. It reads from
 * the SQL database or user inputs to produce the data tables and statistical information the program displays.
 *
 * This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. If a copy of the MPL was not 
 * distributed with this file, You can obtain one at https://mozilla.org/MPL/2.0/. */

using System.Data;

namespace UberTracker
{
    public class Deliveries
    {
        public int entries;
        public DataTable tripTable;

        public Deliveries()
        {
            entries = 0;
            tripTable = new DataTable("TripTable");
            DataColumn id = new DataColumn();
            DataColumn tripDate = new DataColumn();
            DataColumn tripType = new DataColumn();
            DataColumn wasStackedDelivery = new DataColumn();
            DataColumn deliveryCount = new DataColumn();
            DataColumn duration = new DataColumn();
            DataColumn origZipCode = new DataColumn();
            DataColumn distance = new DataColumn();
            DataColumn finalZipCode = new DataColumn();
            DataColumn points = new DataColumn();
            DataColumn fareBase = new DataColumn();
            DataColumn fareSupplement = new DataColumn();
            DataColumn fareSubtotal = new DataColumn();
            DataColumn tip = new DataColumn();
            DataColumn tolls = new DataColumn();
            DataColumn other = new DataColumn();
            DataColumn total = new DataColumn();

            id.ColumnName = "ID";
            id.DataType = System.Type.GetType("System.Int");
            tripTable.Columns.Add(id);
            tripDate.ColumnName = "Date/Time";
            tripDate.DataType = System.Type.GetType("System.DateTime");
            tripTable.Columns.Add(tripDate);
            tripType.ColumnName = "Trip Type";
            tripType.DataType = System.Type.GetType("System.String");
            tripTable.Columns.Add(tripType);
            wasStackedDelivery.ColumnName = "Stacked Delivery?";
            wasStackedDelivery.DataType = System.Type.GetType("System.Boolean");
            tripTable.Columns.Add(wasStackedDelivery);
            deliveryCount.ColumnName = "Delivery Count";
            deliveryCount.DataType = System.Type.GetType("System.Int");
            tripTable.Columns.Add(deliveryCount);
            duration.ColumnName = "Trip Duration";
            duration.DataType = System.Type.GetType("System.String");
            tripTable.Columns.Add(duration);
            origZipCode.ColumnName = "ZIP Code (Origin)";
            origZipCode.DataType = System.Type.GetType("System.Int");
            tripTable.Columns.Add(origZipCode);
            distance.ColumnName = "Trip Distance";
            distance.DataType = System.Type.GetType("System.Decimal");
            tripTable.Columns.Add(distance);
            finalZipCode.ColumnName = "ZIP Code (Destination)";
            finalZipCode.DataType = System.Type.GetType("System.Int");
            tripTable.Columns.Add(finalZipCode);
            points.ColumnName = "Points";
            points.DataType = System.Type.GetType("System.Int");
            tripTable.Columns.Add(points);
            fareBase.ColumnName = "Base Fare";
            fareBase.DataType = System.Type.GetType("System.Decimal");
            tripTable.Columns.Add(fareBase);
            fareSupplement.ColumnName = "Fare Supplement";
            fareSupplement.DataType = System.Type.GetType("System.Decimal");
            tripTable.Columns.Add(fareSupplement);
            fareSubtotal.ColumnName = "Fare Subtotal";
            fareSubtotal.DataType = System.Type.GetType("System.Decimal");
            tripTable.Columns.Add(fareSubtotal);
            tip.ColumnName = "Tip";
            tip.DataType = System.Type.GetType("System.Decimal");
            tripTable.Columns.Add(tip);
            tolls.ColumnName = "Tolls";
            tolls.DataType = System.Type.GetType("System.Decimal");
            tripTable.Columns.Add(tolls);
            other.ColumnName = "Other Adjustments";
            other.DataType = System.Type.GetType("System.Decimal");
            tripTable.Columns.Add(other);
            total.ColumnName = "Total";
            total.DataType = System.Type.GetType("System.Decimal");
            tripTable.Columns.Add(total);
        }

        public int LoadFromSql(String connectionString, bool overwrite = false)
        {
            int n = 0;
            return n;
        }
    }
}