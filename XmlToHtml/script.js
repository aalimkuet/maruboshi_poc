document.addEventListener("click", function (event) {
  console.log("Clicked element:", event.target);
  //geekPrompt();
  // myPopup.show();
});

function geekPrompt() {
  let x = prompt("Enter your mail here : ");
  document.write("Your ID : " + x);
}

const myPopup = new Popup({
  id: "my-popup",
  title: "My First Popup",
  content: `
        An example popup.
        Supports multiple lines.`,
});
