// popover
var popoverTriggerList = [].slice.call(document.querySelectorAll('[data-bs-toggle="popover"]'));
var popoverList = popoverTriggerList.map(function (popoverTriggerEl) {
  return new bootstrap.Popover(popoverTriggerEl);
});
function closeDropdownMenu(secondMenu) {
    document.getElementById(secondMenu).click();
}
/*
$('.navbar-nav li.nav-item a').on('click', function (event) {
    alert("clicked");
    $('#secondMenu').click();
    //$(this).parent().toggleClass('open');
});
*/
// Gender Select
/*
if (window.location.pathname === "/") {
  const radioBtn1 = document.querySelector("#flexRadioDefault1");
  const radioBtn2 = document.querySelector("#flexRadioDefault2");
  const radioBtn3 = document.querySelector("#flexRadioDefault3");
  const genderSelect = document.querySelector("#genderSelect");

  radioBtn1.addEventListener("change", () => {
    genderSelect.classList.add("d-none");
  });
  radioBtn2.addEventListener("change", () => {
    genderSelect.classList.add("d-none");
  });
  radioBtn3.addEventListener("change", () => {
    genderSelect.classList.remove("d-none");
  });
}
*/

/*Light box*/

function openModal(myModal) {
    document.getElementById(myModal).style.display = "block";
}

function closeModal(myModal) {
    document.getElementById(myModal).style.display = "none";
}

var slideIndex = 1;
//showSlides(slideIndex);

function plusSlides(postid,n) {
    showSlides(postid,slideIndex += n);
}

function currentSlide(postid,n) {
    showSlides(postid,slideIndex = n);
}

function showSlides(postid,n) {
    var i;
    parent = document.getElementById(postid);
    var slides = parent.querySelectorAll('.mySlides');
    //var slides = document.getElementsByClassName("mySlides");
    //var dots = parent.querySelectorAll('.demo');
    //var dots = document.getElementsByClassName("demo");
    //var captionText = document.getElementById("caption");
    if (n > slides.length) { slideIndex = 1 }
    if (n < 1) { slideIndex = slides.length }
    for (i = 0; i < slides.length; i++) {
        slides[i].style.display = "none";
    }
    //for (i = 0; i < dots.length; i++) {
    //    dots[i].className = dots[i].className.replace(" active", "");
    //}
    slides[slideIndex - 1].style.display = "block";
    dots[slideIndex - 1].className += " active";
    //captionText.innerHTML = dots[slideIndex - 1].alt;
}

/*End*/

/*Video Lightbox */
window.document.onkeydown = function (e) {
    if (!e) {
        e = event;
    }
    if (e.keyCode == 27) {
        lightbox_close();
    }
}

function lightbox_open() {
    var lightBoxVideo = document.getElementById("VisaChipCardVideo");
    window.scrollTo(0, 0);
    document.getElementById('light').style.display = 'block';
    document.getElementById('fade').style.display = 'block';
    lightBoxVideo.play();
}

function lightbox_close() {
    var lightBoxVideo = document.getElementById("VisaChipCardVideo");
    document.getElementById('light').style.display = 'none';
    document.getElementById('fade').style.display = 'none';
    lightBoxVideo.pause();
}
/*End*/