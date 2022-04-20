@model AddPassengersFormModel

@{
    ViewData["Title"] = "Passengers";
}



<div class="container">
    <div class="row">
        <div class="col-sm-12 offset-lg-2 col-lg-8 offset-xl-3 col-xl-6">
            <h2 class="heading-margin text-center">Add new flight</h2>

            <form method="post">
                <div class="form-group">
                    <label asp-for="Destination"></label>
                    <input asp-for="Destination" class="form-control" placeholder="London, Paris, New York, ...">
                </div>
                <div class="form-group">
                    <label asp-for="Model"></label>
                    <input asp-for="Model" class="form-control" placeholder="Airbus, Boeing, etc...">
                </div>
                <div class="form-group">
                    <label asp-for="Description"></label>
                    <textarea asp-for="Description" rows="5" class="form-control" placeholder="Add your text here..."></textarea>
                </div>
                <div class="form-group">
                    <label asp-for="ImageUrl"></label>
                    <input asp-for="ImageUrl" class="form-control" placeholder="You file URL here...">
                </div>
                <div class="form-group">
                    <label asp-for="Year"></label>
                    <input asp-for="Year" class="form-control" placeholder="@DateTime.UtcNow.Year">
                </div>
                <div class="form-group">
                    <label for="exampleFormControlSelect1">Example select</label>
                    <select class="form-control" id="exampleFormControlSelect1">
                        <option>1</option>
                        <option>2</option>
                        <option>3</option>
                        <option>4</option>
                        <option>5</option>
                    </select>
                </div>
                <div class="form-group">
                    <label for="exampleFormControlSelect2">Example multiple select</label>
                    <select multiple class="form-control" id="exampleFormControlSelect2">
                        <option>1</option>
                        <option>2</option>
                        <option>3</option>
                        <option>4</option>
                        <option>5</option>
                    </select>
                </div>
                <div class="form-group">
                    <label for="exampleFormControlTextarea1">Example textarea</label>
                    <textarea class="form-control" id="exampleFormControlTextarea1"></textarea>
                </div>
                
                <input class="btn btn-primary float-right" type="submit" value="Save"/>
            </form>
        </div>
    </div>
</div>


