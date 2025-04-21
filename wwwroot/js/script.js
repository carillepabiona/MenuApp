// ----- Search Box -----
function showSearchBox() {
    document.getElementById("searchBox").style.display = "flex";
    document.getElementById("controlBox").style.display = "none";
    document.getElementById("txtSearch").focus();
}

function hideSearchBox() {
    document.getElementById("searchBox").style.display = "none";
    document.getElementById("controlBox").style.display = "inline";
}

// Chat Notification function
function showChatNotification() {
    const chatBadge = document.getElementById("chatBadge");
    if (!document.getElementById("chatBox").classList.contains("open")) {
        chatBadge.style.display = "inline-block";
    }
}


// Add to cart notification
window.showToast = (message) => {
    const toast = document.getElementById("toast");
    toast.textContent = message || "Item added to cart!";
    toast.classList.add("show");

    setTimeout(() => {
        toast.classList.remove("show");
    }, 3000);
};


// ----- Chat Box Logic -----
function toggleChat(event) {
    const chatBox = document.getElementById("chatBox");


    chatBox.classList.toggle("open");

    // Listen for clicks outside to close
    if (chatBox.classList.contains("open")) {
        document.getElementById("chatBadge").style.display = "none"; // Hide notification dot when opened
        document.addEventListener("click", closeOnClickOutside);
    } else {
        document.removeEventListener("click", closeOnClickOutside);
    }


    event.stopPropagation(); // Prevent click from propagating
}

// ----- Close Cart or Chat when Clicking Outside -----
function closeOnClickOutside(event) {
    const chatBox = document.getElementById("chatBox");
    const chatToggle = document.querySelector(".chat-toggle");

    // Check if the click is outside both containers and buttons
    if (
        !chatBox.contains(event.target) &&
        !chatToggle.contains(event.target)
    ) {
        chatBox.classList.remove("open");

        // Remove event listener to prevent unnecessary checks
        document.removeEventListener("click", closeOnClickOutside);
    }

}





