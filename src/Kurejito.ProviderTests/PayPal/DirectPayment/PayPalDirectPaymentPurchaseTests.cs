﻿using Kurejito.Gateways.PayPal;
using Kurejito.Gateways.PayPal.DirectPayment;
using Kurejito.Payments;
using Kurejito.Transport;
using Should;
using Xunit;

namespace Kurejito.ProviderTests.PayPal.DirectPayment {
    public class PayPalDirectPaymentPurchaseTests {
        [Fact]
        public void Purchase_Successful_Against_Sandbox() {
            var payPalNvpPaymentGateway = new PayPalDirectPaymentGateway(new HttpTransport(), PayPalEnvironment.NegativeTestAccountSandboxEnvironment());
            payPalNvpPaymentGateway.Purchase("REF", 105.05m, "GBP", new PaymentCard("BEN TAYLOR", "4716034283508634", new CardDate(10, 2015), "123", CardType.Visa)).Status.ShouldEqual(PaymentStatus.Ok);
        }
    }
}