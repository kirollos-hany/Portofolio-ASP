
const feedbackContainer = document.getElementById("feedbackContainer");
const feedbackDisplay = document.getElementById("displayFeedback");
feedbackDisplay.style.display = "none";
const descriptionContainer = document.getElementById("descriptionContainer");
feedbackContainer.addEventListener('click', makeFeedbackActive);
descriptionContainer.addEventListener('click', makeDescriptionActive);


function makeFeedbackActive()
{
    const feedbackDisplay = document.getElementById("displayFeedback");
    feedbackDisplay.style.display = "block";
    const feedbackContainer = document.getElementById("feedbackContainer");
    feedbackContainer.classList.toggle("active-container");
    const descriptionDisplay = document.getElementById("displayDescription");
    descriptionDisplay.style.display = "none";
    const descriptionContainer = document.getElementById("descriptionContainer");
    descriptionContainer.classList.toggle("active-container");
}

function makeDescriptionActive()
{
    const descriptionDisplay = document.getElementById("displayDescription");
    descriptionDisplay.style.display = "block";
    const descriptionContainer = document.getElementById("descriptionContainer");
    descriptionContainer.classList.toggle("active-container");
    const feedbackDisplay = document.getElementById("displayFeedback");
    feedbackDisplay.style.display = "none";
    const feedbackContainer = document.getElementById("feedbackContainer");
    feedbackContainer.classList.toggle("active-container");
}

