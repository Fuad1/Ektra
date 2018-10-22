var GigDetailsController = function (followingService) {
    var followButton;

    var done = function () {
        const text = (followButton.text() === "Follow") ? "Following" : "Follow";

        followButton.toggleClass("btn-info").toggleClass("btn-default").text(text);
    };

    var fail = function () {
        alert("Something failed!!!");
    };

    var toggleFollow = function (e) {
        followButton = $(e.target);
        var followeeId = followButton.attr("data-user-id");

        if (followButton.hasClass("btn-default"))
            followingService.createFollowing(followeeId, done, fail);
        else
            followingService.deleteFollowing(followeeId, done, fail);

    }

    var init = function () {
        $(".js-toggle-follow").click(toggleFollow);
    };

    return {
        init: init
    }
}(FollowingService);