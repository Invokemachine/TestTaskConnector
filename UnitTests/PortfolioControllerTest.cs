using Xunit;

namespace UnitTests
{
    public sealed class PortfolioConnectorTest
    {
        [Fact]
        public void TotalAmountCount()
        {
            decimal TotalPortfolioAmountInUSD = 126821.4m;
            decimal BTCAmount = 1;
            decimal XPRAmount = 15000;
            decimal XMRAmount = 50;
            decimal DASHAmount = 30;

            decimal USDtoBTC = 82641.00m;  
            decimal USDtoXPR = 2.21m;
            decimal USDtoXMR = 207.45m;
            decimal USDtoDASH = 21.93m;

            decimal ActualTotalAmount = BTCAmount * USDtoBTC + XPRAmount * USDtoXPR + XMRAmount * USDtoXMR + DASHAmount * USDtoDASH;
            Assert.Equal(TotalPortfolioAmountInUSD, ActualTotalAmount);
        }

        [Fact]
        public void BTCtoUSDCount()
        {
            decimal FinalAmountInUSD = 82641.00m;
            decimal BTCAmount = 1;
            decimal USDtoBTC = 82641.00m;
            decimal ActualAmountInUSD = BTCAmount * USDtoBTC;
            Assert.Equal(FinalAmountInUSD, ActualAmountInUSD);
        }

        [Fact]
        public void XPRtoUSDCount()
        {
            decimal FinalAmountInUSD = 33150;
            decimal XPRAmount = 15000;
            decimal USDtoXPR = 2.21m;
            decimal ActualAmountInUSD = XPRAmount * USDtoXPR;
            Assert.Equal(FinalAmountInUSD, ActualAmountInUSD);
        }

        [Fact]
        public void XMRtoUSDCount()
        {
            decimal FinalAmountInUSD = 10372.5m;
            decimal XMRAmount = 50;
            decimal USDtoXMR = 207.45m;
            decimal ActualAmountInUSD = XMRAmount * USDtoXMR;
            Assert.Equal(FinalAmountInUSD, ActualAmountInUSD);
        }

        [Fact]
        public void DASHtoUSDCount()
        {
            decimal FinalAmountInUSD = 657.9m;
            decimal DASHAmount = 30;
            decimal USDtoDASH = 21.93m;
            decimal ActualAmountInUSD = DASHAmount * USDtoDASH;
            Assert.Equal(FinalAmountInUSD, ActualAmountInUSD);
        }

        [Fact]
        public void TotalAmountInUSDCheck()
        {
            decimal FinalAmount = 126821.4m;
            decimal BTCInUSD = 82641.00m;
            decimal XPRInUSD = 33150;
            decimal XMRInUSD = 10372.5m;
            decimal DASHInUSD = 657.9m;
            decimal ActualAmount = BTCInUSD + XPRInUSD + XMRInUSD + DASHInUSD;
            Assert.Equal(FinalAmount, ActualAmount);
        }
    }
}