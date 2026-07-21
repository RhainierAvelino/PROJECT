# SmartStock Prescriptive Inventory Management System

SmartStock is a role-based desktop inventory and point-of-sale system built for a small-business use case. It combines daily inventory operations with business-intelligence features for sales analysis, product-bundle recommendations, stockout-risk monitoring, priority classification, and reorder planning.

## Key features

- Role-based access for administrators and cashiers
- Product and inventory management
- Point-of-sale transactions
- Receipt generation
- Automatic stock updates after sales
- Sales and inventory dashboards
- Apriori-based product-bundle recommendations
- Sales forecasting and business insights
- Stockout-risk and inventory-priority indicators
- Reorder-quantity recommendations
- CSV-based sample-data seeding

## Technology stack

- C#
- Windows Forms
- SQL Server
- Apriori association-rule mining
- Visual Studio

## Main modules

- Authentication and role management
- Product management
- Inventory monitoring
- Cashier and transaction processing
- Sales records and receipt generation
- Business-intelligence dashboard
- Apriori analysis
- Forecasting and inventory recommendations
- CSV sample-data importer

## Requirements

- Windows
- Visual Studio with .NET desktop development tools
- SQL Server or SQL Server Express
- SQL Server Management Studio, recommended

## Setup overview

1. Clone the repository.
2. Open the Visual Studio solution file.
3. Create or restore the required SQL Server database.
4. Update the database connection string to match your local SQL Server instance.
5. Build the solution.
6. Run the application from Visual Studio.
7. Use the included seeding functionality when sample data is needed for demonstration.

## Analytics approach

SmartStock applies Apriori association-rule mining to sales transactions to identify frequently purchased product combinations. These patterns support bundle recommendations and additional business insights. The system also provides forecasting and inventory-planning outputs such as stockout risk, product priority, and reorder quantity.

## Academic context

This project was developed as an academic software solution for an MSME inventory-management scenario. It demonstrates desktop application development, relational database integration, transaction processing, analytics, and prescriptive inventory support.

## Project status

Completed academic prototype. The repository is intended for portfolio and educational demonstration purposes rather than production deployment.

## Author

**Rhainier L. Avelino**  
Project Manager, Lead Developer, and UI/UX Designer  
Bachelor of Science in Information Technology  
Polytechnic University of the Philippines
