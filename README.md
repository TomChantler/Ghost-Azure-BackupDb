# Ghost-Azure-BackupDb

**Backup your SQLite database with zero downtime when running Ghost in Azure Web Apps**

If you're hosting your Ghost blog in Azure then you're probably not backing up your database, even if you think you are. All of the solutions I found online required me either to export the blog data manually (as a json file via the Ghost admin panel), or to stop my blog from running. This very simple solution does away with that requirement.

You can either build the code yourself or simply download `CompiledWebJob\Ghost-Azure-BackupDb.zip` and upload it to your Azure Web App as a WebJob.

Full instructions here: https://tomssl.com/2016/09/12/backup-your-sqlite-database-with-zero-downtime-when-running-ghost-in-azure-web-apps
