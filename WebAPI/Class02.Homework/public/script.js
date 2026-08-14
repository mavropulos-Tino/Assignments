const PORT = "7079";
const URL = `https://localhost:${PORT}/api/users`;

document.getElementById("btnFetchAll").addEventListener("click", async () => {
  const table = document.getElementById("usersTable");
  const tbody = document.getElementById("usersTableBody");

  try {
    const response = await fetch(URL);
    if (!response.ok) throw new Error(`HTTP Error: ${response.status}`);

    const users = await response.json();
    tbody.innerHTML = "";

    users.forEach((x) => {
      const row = `
                    <tr>
                        <td>${x.id}</td>
                        <td>${x.firstName} ${x.lastName}</td>
                        <td>${x.email}</td>
                        <td>${x.age}</td>
                    </tr>
                `;
      tbody.innerHTML += row;
    });

    table.style.display = "table";
  } catch (error) {
    alert(
      "Failed to fetch users. Check console and ensure your API is running with CORS enabled.",
    );
    console.error(error);
  }
});

document.getElementById("btnFetchById").addEventListener("click", async () => {
  const idInput = document.getElementById("userIdInput").value.trim();
  const resultDiv = document.getElementById("singleUserResult");
  const errorDiv = document.getElementById("userError");

  resultDiv.style.display = "none";
  errorDiv.textContent = "";

  if (!idInput) {
    errorDiv.textContent = "Please enter a valid user ID.";
    return;
  }

  try {
    const response = await fetch(`${URL}/${idInput}`);

    if (response.status === 404) {
      const errorData = await response.json();
      errorDiv.textContent =
        errorData.message || `User with ID ${idInput} not found.`;
      return;
    }

    if (!response.ok) throw new Error(`HTTP Error: ${response.status}`);

    const user = await response.json();
    resultDiv.innerHTML = `
                <p><strong>ID:</strong> ${user.id}</p>
                <p><strong>Full Name:</strong> ${user.firstName} ${user.lastName}</p>
                <p><strong>Email:</strong> ${user.email}</p>
                <p><strong>Age:</strong> ${user.age}</p>
            `;
    resultDiv.style.display = "block";
  } catch (error) {
    errorDiv.textContent = "Error connecting to API. Verify API is running.";
    console.error(error);
  }
});
