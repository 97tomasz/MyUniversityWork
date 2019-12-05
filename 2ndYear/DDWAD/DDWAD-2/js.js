function search() {
    var searchCriteria = document.getElementById("search").value.toUpperCase();
    var listToSearch = document.getElementById("theList").getElementsByTagName('li');

    // if nothing in search box, reset all list items to be displayed
    if (!searchCriteria) {
        Array.from(listToSearch).forEach((e) => {
            e.style.display = "";
        });
        return;
    }

    // otherwise if there is something in search box, do the search and hide non-matching items
   Array.from(listToSearch).forEach((e) => {
        var txtValue = e.textContent.toUpperCase();
        if (txtValue.indexOf(searchCriteria) > -1) {
            e.style.display = ""; // matching
        } else {
            e.style.display = "none"; // non matching
        }
   });
}