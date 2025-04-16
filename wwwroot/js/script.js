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

// Chat Toggle function
function toggleChat() {
    const chatSidebar = document.getElementById("chatSidebar");
    chatSidebar.classList.toggle("open");

    if (chatSidebar.classList.contains("open")) {
        // Add event listener for outside click
        document.addEventListener("click", closeChatOnOutsideClick);
    } else {
        document.removeEventListener("click", closeChatOnOutsideClick);
    }
}

function closeChatOnOutsideClick(event) {
    const chatSidebar = document.getElementById("chatSidebar");
    const chatToggle = document.querySelector(".chat-toggle");

    if (!chatSidebar.contains(event.target) && !chatToggle.contains(event.target)) {
        chatSidebar.classList.remove("open");
        document.removeEventListener("click", closeChatOnOutsideClick);
    }
}









