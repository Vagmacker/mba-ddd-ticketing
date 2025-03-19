namespace Ticketing.UnitTests.Domain;

using Shouldly;
using PartnerEntity = Ticketing.Domain.Partner.Partner;

public class PartnerTest
{
    [Trait("Domain", "Partner Aggregate")]
    [Fact(DisplayName = nameof(GivenAValidParams_WhenCallNewPartner_ThenInstantiateAPartner))]
    public void GivenAValidParams_WhenCallNewPartner_ThenInstantiateAPartner()
    {
        // Given
        const string expectedName = "Partner Name";

        // When
        var partner = PartnerEntity.NewPartner(expectedName);

        // Then
        partner.ShouldNotBeNull();
        partner.Name.ShouldBe(expectedName);
        partner.Id.ShouldNotBe(Guid.Empty);
        partner.CreatedAt.ShouldNotBe(default);
        partner.UpdatedAt.ShouldNotBe(default);
    }
}