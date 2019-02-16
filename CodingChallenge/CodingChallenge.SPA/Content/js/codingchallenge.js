var uri = 'http://localhost:51082';

$(document).ready(function () {
    $("#projectSelect").append('<option value=\'\'>Select an user...</option>');
    $.get(uri + "/api/user")
        .done(function (data) {
            $.each(data, function (key, item) {
                $("#projectSelect").append('<option value=' + item.Id + '>' +  getFullName(item) + '</option>');
            });
        });
});

function getFullName(item) {
    return item.FirstName + ' ' + item.LastName;
}

function getProjects()
{
    var projectsBody = '';
    
    var userIdSelected = $("#projectSelect option:selected").val();

    if (userIdSelected != null && userIdSelected != "")
    {        
        $.get(uri + "/api/project/" + userIdSelected)
            .done(function (data) {
                $.each(data, function (key, item) {
                    console.log(item.ProjectId);
                    projectsBody += '<tr>' 
                                    + '<td>' + item.ProjectId + '</td>'
                                    + '<td>' + getDateTimeFormatted(item.StartDate) + '</td>'
                                    + '<td>' + item.TimeToStart + '</td>'
                                    + '<td>' +  getDateTimeFormatted(item.EndDate) + '</td>'
                                    + '<td>' + item.Credits + '</td>'
                                    + '<td>' + item.Status + '</td>'
                                    + '</tr>';
                });
            
                $('#projectsTable tbody').html("");
                $('#projectsTable tbody').append(projectsBody);
      });
    }
    else {
        $('#projectsTable tbody').html("");
    }

}
function getDateTimeFormatted(date)
{
    var dateConverted = new Date(date);
    return dateConverted.getDate() + '/' + dateConverted.getMonth() + '/' + dateConverted.getFullYear();
}
