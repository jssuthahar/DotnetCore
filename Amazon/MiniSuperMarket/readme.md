# Amazon Homepage Project

This project is a beginner-friendly Amazon homepage clone using **HTML** and **CSS**. Below, you'll find a detailed explanation of how the website is structured and styled, and why each part is used. This will help you understand how to build and style modern web pages.

---

## 📁 Project Structure

```
amazon-homepage-clone/
│
├── View/index.cshtml     # Home HTML file (structure/content)
├── View/Shared/_Layout.cshtml          # Master HTML file (structure/content)
├── style.css          # CSS file (styling/design)
└── images/            # Images used in the website
```

---

## 📝 index.cshtml - Structure Explained

### 1. **`<!DOCTYPE html>` and `<html>`**
- Declares the document as HTML5 and starts the HTML document.

### 2. **`<head>`**
- Contains meta information, title, links to CSS, and Google Material Icons.

### 3. **`<body>`**
- All visible content is inside the body.

#### **Header Section**
- **`<header>`**: Contains the navigation bar and banner.
- **`<nav class="navbar">`**: Top navigation with logo, location, search bar, sign-in, orders, and cart.
- **`<div class="banner">`**: Secondary navigation with menu and quick links.

#### **Hero Section**
- **`<section class="hero-section">`**: Large banner image area (styled with CSS).

#### **Shop Section**
- **`<section class="shop-section">`**: Contains product category cards.
    - **`<div class="shop-link">`**: Each card has a title, image, and "Shop now" link.

#### **Footer**
- **`<footer>`**: Contains "Back to top" and four columns of helpful links.

---

## 🎨 style.css - Styling Explained

### **General Styles**
- **Font Import**: Uses Google Fonts for a clean look.
- **Reset Styles**: Removes default margins/paddings and sets box-sizing for easier layout control.
- **Links**: Removes underlines and sets default/hover colors.

### **Header & Navbar**
- **`header`**: Full-width, dark background for Amazon feel.
- **`.navbar`**: Flexbox for horizontal layout, centers items, and spaces them out.
- **Logo**: Sized and spaced for visibility.
- **Address/Location**: Small text for "Deliver", icon and location name.
- **Search Bar**: Flexbox layout, rounded corners, colored search button.
- **Sign-in/Returns/Cart**: Styled for clarity, cart icon enlarged.

### **Banner**
- **`.banner`**: Secondary navigation bar, dark background.
- **`.banner-content`**: Flexbox for horizontal alignment.
- **`.panel`**: Menu icon and "All" link.
- **`.links`**: List of navigation links, spaced out.
- **`.deals`**: Highlighted deals link.

### **Hero Section**
- **`.hero-section`**: Large background image, covers width, fixed height.

### **Shop Section**
- **`.shop-section`**: Centered content, light background, padding for space.
- **`.shop-images`**: CSS Grid for responsive card layout.
- **`.shop-link`**: White card, padding, vertical layout, hover effect on link.
- **Images**: Sized to fit cards, object-fit for neat cropping.
- **Links**: Blue by default, orange on hover for Amazon style.

### **Footer**
- **`.footer-title`**: "Back to top" bar, centered text.
- **`.footer-items`**: Four columns, flexbox layout, dark background.
- **Column Titles**: White, bold.
- **Links**: Light color, underline on hover.

---

## 🛠️ How the Website Was Designed

1. **Header**: Uses Flexbox to arrange logo, location, search, and user/cart links in a row.
2. **Banner**: Another Flexbox row for quick navigation links.
3. **Hero Section**: Large, attractive background image for visual impact.
4. **Shop Section**: CSS Grid displays product cards responsively (adapts to screen size).
5. **Footer**: Flexbox arranges four columns of links for easy navigation.

**Material Icons** are used for location, menu, search, and cart, giving a modern look.

---

## 💡 Why Use These Tags and Styles?

- **Semantic HTML**: Tags like `<header>`, `<nav>`, `<section>`, and `<footer>` make the structure clear and accessible.
- **Flexbox & Grid**: Modern CSS layout tools for responsive, easy-to-manage designs.
- **Consistent Colors & Fonts**: Mimics Amazon’s branding and improves readability.
- **Hover Effects**: Improve user experience by providing feedback.
- **Responsive Design**: Layout adapts to different screen sizes.

---

## 📚 Learning Resources

- [HTML Tutorial (W3Schools)](https://www.w3schools.com/html/)
- [CSS Tutorial (W3Schools)](https://www.w3schools.com/css/)
- [Flexbox Guide (CSS Tricks)](https://css-tricks.com/snippets/css/a-guide-to-flexbox/)
- [Grid Guide (CSS Tricks)](https://css-tricks.com/snippets/css/complete-guide-grid/)
- [Material Symbols](https://fonts.google.com/icons)

---

## 👩‍💻 Try Customizing!

- Change images in the `images/` folder.
- Edit text in `index.html`.
- Modify colors and layout in `style.css`.

