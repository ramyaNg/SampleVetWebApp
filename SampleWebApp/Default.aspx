<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SampleWebApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <div class="container vet-directory-header">
            <div class="col-12">
                <div class="col-md-9">
                    <h1 class="title">Vet Directory </h1>
                    <span class="sub-title">Find a Vet Near You</span>
                </div>
            </div>
        </div>

        <div class="container store-locator-container vet-directory">
            <div class="row">
                <div class="col-sm-4 d-flex align-items-start flex-column">
                    <div class="card">
                        <div class="card-body">
                            <ul class="list-group list-group-flush">
                                <li class="list-group-item">
                                    <h6>Option 1: Search by Zip Code</h6>
                                    <div class="store-locator" name="storelocator">
                                        <div class="form-group required">
                                            <label class="form-control-label" style="margin: 10px">ZIP Code or Postal Code</label>
                                            <input autofocus="" type="text" class="form-control" title="zipcode" style="margin: 10px" aria-describedby="store-zip-input" id="postalCode"  EnableViewState= "false" runat="server" pattern="[0-9]*">
                                            <div aria-invalid="true" role="alert" class="invalid-feedback"></div>
                                        </div>
                                        <asp:Button ID="yourButtonId" OnClick="GetSearchResultsByZip" CssClass="btn btn-block btn-primary btn-citystate-search" Text="Submit" runat="server" />
                                    </div>
                                </li>
                                <li class="list-group-item secondary">
                                    <h6>Option 2: Search by City &amp; State</h6>
                                    
                                        <input type="hidden" name="horizontalView" value="true">
                                        <div class="form-group required">
                                            <label class="form-control-label" for="store-city" style="margin: 10px">City</label>
                                            <input autofocus="" type="text" class="form-control" id="storecity" style="margin: 10px" aria-describedby="store-city-input"  value="" runat="server" autocomplete="nofill">
                                            <label class="form-control-label" for="store-state" style="margin: 10px">State </label>
                                            <select autofocus="" class="form-control" id="storestate" name="state" value="null" autocomplete="nofill" required="" runat="server">
                                                <option aria-describedby="store-state-input" id="CA" value="CA">CA</option>
                                                <option aria-describedby="store-state-input" id="FL" value="FL">FL</option>
                                            </select>
                                            <div aria-invalid="true" role="alert" class="invalid-feedback"></div>
                                        </div>
                                         <asp:Button ID="Button2" OnClick="GetSearchResultsByState" CssClass="btn btn-block btn-primary btn-citystate-search" Text="Submit" runat="server" />
                                   
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
                <div class="col-sm-8">
                    <div class="card results-card">
                        <div class="card-body">

                            <div class="results" data-has-results="false">

                                <div>
                                    <% if (vetSampleData.Count > 0)
                                        { %>
                                    <div class="search-results-header">
                                        <span>Search Results for your area:</span>
                                    </div>
                                    <div class="row">
                                        <% foreach (var data in vetSampleData)
                                            { %>
                                        <div class="card-body col-6">
                                            <div class="store-details col-12">
                                                <%= data.HopitalName %>
                                            </div>
                                            <address>
                                                <div>
                                                    <%= data.Address %>
                                                </div>
                                                <%= data.City %> , 
                                                <%= data.State %>
                                                <%= data.ZipCode %>
                                                <div class="phone">
                                                    <i class="fa fa-phone" aria-hidden="true"></i>
                                                    <span><a class="storelocator-phone"><%= data.ContactNumber %></a></span>
                                                </div>
                                            </address>
                                        </div>
                                        <% }%>
                                    </div>
                                    <%   } %>

                                    <% else
                                        { %>
                                    <p role="alert" aria-live="polite" class="text-center store-locator-no-results" style="display: block;">We're sorry, we couldn't find results for your search.</p>
                                    <% } %>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </main>

</asp:Content>
