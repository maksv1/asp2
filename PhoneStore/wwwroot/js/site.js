    function openSpecsModal(productId) {
        // Заглушка данных, заменить на загрузку данных с сервера
        const mockData = {
        2: {
        name: "Apple iPhone 15 128GB Black",
    company: "Apple",
    year: "2023",
    memory: "128 GB",
    price: "70 191 ₽"
            },
         1: {
                name: "Apple iPhone 15 128GB Black",
                company: "Apple",
                year: "2023",
                memory: "128 GB",
                price: "70 191 ₽"
            }
        };

    // Получение данных по productId
    const productData = mockData[productId];

    if (productData) {
        // Заполнение данных в модальном окне
        document.getElementById('modalProductName').textContent = productData.name || "Нет данных";
    document.getElementById('modalProductCompany').textContent = productData.company || "Нет данных";
    document.getElementById('modalProductYear').textContent = productData.year || "Нет данных";
    document.getElementById('modalProductMemory').textContent = productData.memory || "Нет данных";
    document.getElementById('modalProductPrice').textContent = productData.price || "Нет данных";

    // Открытие модального окна
    $('#productSpecsModal').modal('show');
        } else {
        alert("Ошибка загрузки данных!");
        }
}
function closeModal() {
    $('#productSpecsModal').modal('hide'); // ID вашего модального окна
}
