echo ::: Running MSTest..
MSTest.exe /testcontainer:UnitTests.dll /resultsfile:TestResults.trx 


ReportUnit15.exe TestResults.trx


